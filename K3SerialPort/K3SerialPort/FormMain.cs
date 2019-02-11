using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace K3SerialPort
{
    public partial class FormMain : Form
    {
        SerialPort sPort;

        public System.Windows.Forms.Timer tmr_sts;
        public static bool btmr_sts = false;

        public System.Windows.Forms.Timer tmr_enc;
        public static bool btmr_enc = false;

        public System.Windows.Forms.Timer tmr_spi;
        public static bool btmr_spi = false;
        public static bool bSPIWrite = false;
        public static int iSPIWrite = 0;

        public static bool bFANOn = false;

        public static byte[] DataBuff;  // Data receive buffer
        public static int iDataIndex = 0;
        public static bool bGetData = false;

        //public static bool bRelease = true;
        public static bool bRelease = false;

        public static string strLineData = "";

        public FormMain()
        {
            InitializeComponent();

            if(bRelease)
            {
                chkRecHexa.Visible = false;
                chkSndHexa.Visible = false;
                chkSndAck.Visible = false;

                btnFANOnOff.Visible = false;
                btnMainDCHold.Visible = false;
                btnMainDCTestOff.Visible = false;
                btnMainDCTestOn.Visible = false;

                btnZCCW.Visible = false;
                btnZCW.Visible = false;
                btnZStop.Visible = false;
            }

            DataBuff = new byte[1024];
            //DataBuff[0] = 0xff;
            System.Array.Clear(DataBuff, 0, DataBuff.Length);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tmr_sts = new System.Windows.Forms.Timer();
            tmr_sts.Interval = 300;         // 300 ms timer initialize
            tmr_sts.Tick += new System.EventHandler(this.tmr_sts_Tick);

            tmr_enc = new System.Windows.Forms.Timer();
            tmr_enc.Interval = 300;         // 300 ms timer initialize
            tmr_enc.Tick += new System.EventHandler(this.tmr_enc_Tick);

            tmr_spi = new System.Windows.Forms.Timer();
            tmr_spi.Interval = 300;         // 300 ms timer initialize
            tmr_spi.Tick += new System.EventHandler(this.tmr_spi_Tick);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            cboPortName.BeginUpdate();
            foreach (string comport in SerialPort.GetPortNames())
            {
                cboPortName.Items.Add(comport);
            }
            cboPortName.EndUpdate();

            //cboPortName.SelectedItem = "COM4";
            try
            {
                cboPortName.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Port does not exist!");
            }

            //txtBaudRate.Text = "9600";
            txtBaudRate.Text = "500000";

            CheckForIllegalCrossThreadCalls = false;
        }

        private void tmr_sts_Tick(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("sts" + "\r\n");
        }

        private void tmr_enc_Tick(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("enc" + "\r\n");
        }

        private void tmr_spi_Tick(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                if(bSPIWrite)
                {
                    bSPIWrite = false;
                    sPort.Write("spir" + "\r\n");
                }
                else
                {
                    bSPIWrite = true;
                    sPort.Write("spi " + iSPIWrite.ToString() + "\r\n");
                    iSPIWrite++;
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (null == sPort)
                {
                    sPort = new SerialPort();
                    sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);

                    sPort.PortName = cboPortName.SelectedItem.ToString();
                    sPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                    sPort.DataBits = (int)8;
                    sPort.Parity = Parity.None;
                    sPort.StopBits = StopBits.One;
                    sPort.ReadTimeout = (int)500;
                    sPort.WriteTimeout = (int)500;
                    sPort.Open();
                }

                if (sPort.IsOpen)
                {
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;

                    //MessageBox.Show("시리얼 포트를 연결했습니다.");
                }
                else
                {
                    btnOpen.Enabled = true;
                    btnClose.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intRecSize = sPort.BytesToRead;
            string strRecData;

            if (intRecSize != 0)
            {
                strRecData = "";
                byte[] buff = new byte[intRecSize];

                sPort.Read(buff, 0, intRecSize);
                for (int iTemp = 0; iTemp < intRecSize; iTemp++)
                {
                    if (chkRecHexa.Checked)
                    {
                        strRecData += buff[iTemp].ToString("X2") + " ";
                        if (buff[iTemp] == 0x02)         // STX
                        {
                            bGetData = true;
                            //DataBuff[iDataIndex++] = buff[iTemp];
                        }
                        else if (buff[iTemp] == 0x03)   // ETX
                        {
                            DataBuff[iDataIndex++] = buff[iTemp];
                            bGetData = false;
                            string strDataBuff = "";
                            for (int i = 0; i < iDataIndex; i++)
                                strDataBuff += DataBuff[i].ToString("X2") + " ";

                            // Data parsing.
                            if ((DataBuff[3] == 0x05) && (DataBuff[4] == 0x66))
                            {
                                byte[] byteSendData = new byte[200];
                                int iSendCount = 0;
                                String strSendData = "02 01 06 ";
                                strSendData += (DataBuff[3].ToString("X2") + " " + (DataBuff[4] + 1).ToString("X2") + " ");
                                strSendData += "03";

                                foreach (string s in strSendData.Split(' '))
                                {
                                    if (s != null && s != "")
                                    {
                                        byteSendData[iSendCount++] = Convert.ToByte(s, 16);
                                    }
                                }

                                if(chkSndAck.Checked)
                                {
                                    for (int i = 0; i < iSendCount + 1; i++)
                                    {
                                        sPort.Write(byteSendData, i, 1);
                                    }
                                }
                            }

                            Console.WriteLine(strDataBuff);
                            iDataIndex = 0;
                            System.Array.Clear(DataBuff, 0, DataBuff.Length);
                        }

                        if(bGetData)
                            DataBuff[iDataIndex++] = buff[iTemp];

                    }
                    else
                    {
                        strLineData += Convert.ToChar(buff[iTemp]);
                        if (buff[iTemp] == 0x0A)         // Line feed
                        {
                            
                            //Console.WriteLine(strLineData);

                            // String parsing data check & process
                            string strKey = "DIPSW:";
                            int iIndex = strLineData.IndexOf(strKey);
                            //int iIndex = strLineData.LastIndexOf("DIPSW:");
                            if (iIndex != -1)
                            {
                                string strDipSW_Status = strLineData.Substring(iIndex + strKey.Length, 4);
                                //Console.WriteLine(strDipSW_Status);
                                if (strDipSW_Status == txtDipSW_Target.Text)
                                    txtDipSW_Result.Text = "OK";
                                else
                                    txtDipSW_Result.Text = "Error";
                            }

                            strLineData = "";   // Clear line data.
                        }

                        strRecData += Convert.ToChar(buff[iTemp]);  // Display data to text box
                    }
                }
                //txtRec.Text += strRecData;
                txtRec.AppendText(strRecData);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (null != sPort)
            {
                if (sPort.IsOpen)
                {
                    sPort.Close();
                    sPort.Dispose();
                    sPort = null;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] byteSendData = new byte[200];
            int iSendCount = 0;
            try
            {
                if (true == chkSndHexa.Checked)
                {
                    foreach (string s in txtSend.Text.Split(' '))
                    {
                        if (s != null && s != "")
                        {
                            byteSendData[iSendCount++] = Convert.ToByte(s, 16);
                        }
                    }

                    //sPort.Write(byteSendData, 0, iSendCount);

                    for (int i = 0; i < iSendCount + 1; i++)
                    {
                        sPort.Write(byteSendData, i, 1);
                    }
                }
                else
                {
                    //byteSendData[0] = 0x41;
                    //sPort.Write(byteSendData, 0, 2);
                    //sPort.Write(txtSend.Text);
                    sPort.Write(txtSend.Text + "\r\n");

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (null != sPort)
            {
                if (sPort.IsOpen)
                {
                    sPort.Close();
                    sPort.Dispose();
                    sPort = null;
                }
            }

            btnOpen.Enabled = true;
            btnClose.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRec.Clear();
        }

        private void btnDbgOn_Click(object sender, EventArgs e)
        {
            if(sPort.IsOpen)
                sPort.Write("dbg on" + "\r\n");
        }

        private void btnSts_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                if (chkRepeat.Checked)
                {
                    if (btmr_sts)
                    {
                        tmr_sts.Stop();
                        btmr_sts = false;
                        txtRec.AppendText("sts stop\r\n");
                        btnSts.Text = "sts";
                    }
                    else
                    {
                        tmr_sts.Start();
                        btmr_sts = true;
                        txtRec.AppendText("sts start\r\n");
                        btnSts.Text = "sts off";
                    }
                }
                else
                {
                    tmr_sts.Stop();
                    btmr_sts = false;
                    btnSts.Text = "sts";
                    sPort.Write("sts" + "\r\n");
                }
            }
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                if (chkRepeat.Checked)
                {
                    if (btmr_enc)
                    {
                        tmr_enc.Stop();
                        btmr_enc = false;
                        txtRec.AppendText("enc stop\r\n");
                        btnEnc.Text = "enc";
                    }
                    else
                    {
                        tmr_enc.Start();
                        btmr_enc = true;
                        txtRec.AppendText("enc start\r\n");
                        btnEnc.Text = "enc off";
                    }
                }
                else
                {
                    tmr_enc.Stop();
                    btmr_enc = false;
                    btnEnc.Text = "enc";
                    sPort.Write("enc" + "\r\n");
                }
            }
        }

        private void btnYCW_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc bwd" + "\r\n");
        }

        private void btnYCCW_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc fwd" + "\r\n");
        }

        private void btnYStop_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc stop" + "\r\n");
        }

        private void btnZCW_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("zax fd" + "\r\n");
        }

        private void btnZCCW_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("zax fu" + "\r\n");
        }

        private void btnZStop_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("zax fs" + "\r\n");
        }


        private void btnMainDCHome_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc home" + "\r\n");
        }

        private void btnMainDCspos_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc spos" + "\r\n");
        }

        private void btnMainDCepos_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc epos" + "\r\n");
        }

        private void btnMainDCHold_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc hold" + "\r\n");
        }

        private void btnMainDCTestOn_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc teston" + "\r\n");
        }

        private void btnMainDCTestOff_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
                sPort.Write("maindc testoff" + "\r\n");
        }

        private void btnFANOnOff_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                if (bFANOn)
                {
                    bFANOn = false;
                    //txtRec.AppendText("sts stop\r\n");
                    sPort.Write("fan off" + "\r\n");
                    btnFANOnOff.Text = "FAN On";
                }
                else
                {
                    bFANOn = true;
                    //txtRec.AppendText("sts start\r\n");
                    sPort.Write("fan on" + "\r\n");
                    btnFANOnOff.Text = "FAN Off";
                }
            }
        }

        private void btnDipSW_Check_Click(object sender, EventArgs e)
        {
            txtDipSW_Result.Text = "None";

            if (sPort.IsOpen)
                sPort.Write("dipsw" + "\r\n");
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //btnSts_Click(sender, e);
                btnSend_Click(sender, null);
            }
        }

        private void btnSPI_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                if (chkRepeat.Checked)
                {
                    if (btmr_spi)
                    {
                        tmr_spi.Stop();
                        btmr_spi = false;
                        txtRec.AppendText("spi stop\r\n");
                        btnSPI.Text = "SPI";
                        iSPIWrite = 0;
                    }
                    else
                    {
                        tmr_spi.Start();
                        btmr_spi = true;
                        txtRec.AppendText("spi start\r\n");
                        btnSPI.Text = "SPI off";
                    }
                }
                else
                {
                    tmr_spi.Stop();
                    btmr_spi = false;
                    iSPIWrite = 0;
                    btnSPI.Text = "SPI";
                    sPort.Write("spir" + "\r\n");
                }
            }
        }


        // Reference) http://son10001.blogspot.kr/2015/07/c-winfrom.html

    }
}
