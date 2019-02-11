namespace K3SerialPort
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.chkRecHexa = new System.Windows.Forms.CheckBox();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkSndHexa = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYCW = new System.Windows.Forms.Button();
            this.btnYCCW = new System.Windows.Forms.Button();
            this.btnYStop = new System.Windows.Forms.Button();
            this.btnZCW = new System.Windows.Forms.Button();
            this.btnZCCW = new System.Windows.Forms.Button();
            this.btnZStop = new System.Windows.Forms.Button();
            this.btnSts = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnDbgOn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMainDCTestOff = new System.Windows.Forms.Button();
            this.btnMainDCepos = new System.Windows.Forms.Button();
            this.btnMainDCTestOn = new System.Windows.Forms.Button();
            this.btnMainDCHome = new System.Windows.Forms.Button();
            this.btnMainDCHold = new System.Windows.Forms.Button();
            this.btnMainDCspos = new System.Windows.Forms.Button();
            this.btnFANOnOff = new System.Windows.Forms.Button();
            this.chkSndAck = new System.Windows.Forms.CheckBox();
            this.btnDipSW_Check = new System.Windows.Forms.Button();
            this.txtDipSW_Target = new System.Windows.Forms.TextBox();
            this.txtDipSW_Result = new System.Windows.Forms.TextBox();
            this.btnSPI = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(84, 24);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(137, 20);
            this.cboPortName.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(240, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(337, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(84, 50);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(136, 21);
            this.txtBaudRate.TabIndex = 3;
            // 
            // chkRecHexa
            // 
            this.chkRecHexa.AutoSize = true;
            this.chkRecHexa.Location = new System.Drawing.Point(351, 55);
            this.chkRecHexa.Name = "chkRecHexa";
            this.chkRecHexa.Size = new System.Drawing.Size(71, 16);
            this.chkRecHexa.TabIndex = 4;
            this.chkRecHexa.Text = "Rcv Hex";
            this.chkRecHexa.UseVisualStyleBackColor = true;
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(14, 266);
            this.txtRec.Multiline = true;
            this.txtRec.Name = "txtRec";
            this.txtRec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRec.Size = new System.Drawing.Size(495, 265);
            this.txtRec.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(84, 77);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(136, 21);
            this.txtSend.TabIndex = 6;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(240, 77);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkSndHexa
            // 
            this.chkSndHexa.AutoSize = true;
            this.chkSndHexa.Location = new System.Drawing.Point(351, 82);
            this.chkSndHexa.Name = "chkSndHexa";
            this.chkSndHexa.Size = new System.Drawing.Size(79, 16);
            this.chkSndHexa.TabIndex = 8;
            this.chkSndHexa.Text = "Send Hex";
            this.chkSndHexa.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 537);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baud Rate :";
            // 
            // btnYCW
            // 
            this.btnYCW.Location = new System.Drawing.Point(14, 179);
            this.btnYCW.Name = "btnYCW";
            this.btnYCW.Size = new System.Drawing.Size(75, 23);
            this.btnYCW.TabIndex = 12;
            this.btnYCW.Text = "Y CW";
            this.btnYCW.UseVisualStyleBackColor = true;
            this.btnYCW.Click += new System.EventHandler(this.btnYCW_Click);
            // 
            // btnYCCW
            // 
            this.btnYCCW.Location = new System.Drawing.Point(95, 179);
            this.btnYCCW.Name = "btnYCCW";
            this.btnYCCW.Size = new System.Drawing.Size(75, 23);
            this.btnYCCW.TabIndex = 13;
            this.btnYCCW.Text = "Y CCW";
            this.btnYCCW.UseVisualStyleBackColor = true;
            this.btnYCCW.Click += new System.EventHandler(this.btnYCCW_Click);
            // 
            // btnYStop
            // 
            this.btnYStop.Location = new System.Drawing.Point(176, 179);
            this.btnYStop.Name = "btnYStop";
            this.btnYStop.Size = new System.Drawing.Size(75, 23);
            this.btnYStop.TabIndex = 14;
            this.btnYStop.Text = "Y Stop";
            this.btnYStop.UseVisualStyleBackColor = true;
            this.btnYStop.Click += new System.EventHandler(this.btnYStop_Click);
            // 
            // btnZCW
            // 
            this.btnZCW.Location = new System.Drawing.Point(270, 179);
            this.btnZCW.Name = "btnZCW";
            this.btnZCW.Size = new System.Drawing.Size(75, 23);
            this.btnZCW.TabIndex = 15;
            this.btnZCW.Text = "Z CW";
            this.btnZCW.UseVisualStyleBackColor = true;
            this.btnZCW.Click += new System.EventHandler(this.btnZCW_Click);
            // 
            // btnZCCW
            // 
            this.btnZCCW.Location = new System.Drawing.Point(351, 179);
            this.btnZCCW.Name = "btnZCCW";
            this.btnZCCW.Size = new System.Drawing.Size(75, 23);
            this.btnZCCW.TabIndex = 16;
            this.btnZCCW.Text = "Z CCW";
            this.btnZCCW.UseVisualStyleBackColor = true;
            this.btnZCCW.Click += new System.EventHandler(this.btnZCCW_Click);
            // 
            // btnZStop
            // 
            this.btnZStop.Location = new System.Drawing.Point(432, 179);
            this.btnZStop.Name = "btnZStop";
            this.btnZStop.Size = new System.Drawing.Size(75, 23);
            this.btnZStop.TabIndex = 17;
            this.btnZStop.Text = "Z Stop";
            this.btnZStop.UseVisualStyleBackColor = true;
            this.btnZStop.Click += new System.EventHandler(this.btnZStop_Click);
            // 
            // btnSts
            // 
            this.btnSts.Location = new System.Drawing.Point(270, 121);
            this.btnSts.Name = "btnSts";
            this.btnSts.Size = new System.Drawing.Size(75, 23);
            this.btnSts.TabIndex = 18;
            this.btnSts.Text = "sts";
            this.btnSts.UseVisualStyleBackColor = true;
            this.btnSts.Click += new System.EventHandler(this.btnSts_Click);
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(351, 121);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(75, 23);
            this.btnEnc.TabIndex = 19;
            this.btnEnc.Text = "enc";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // btnDbgOn
            // 
            this.btnDbgOn.Location = new System.Drawing.Point(14, 121);
            this.btnDbgOn.Name = "btnDbgOn";
            this.btnDbgOn.Size = new System.Drawing.Size(75, 23);
            this.btnDbgOn.TabIndex = 20;
            this.btnDbgOn.Text = "Debug on";
            this.btnDbgOn.UseVisualStyleBackColor = true;
            this.btnDbgOn.Click += new System.EventHandler(this.btnDbgOn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "Send Data :";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Checked = true;
            this.chkRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepeat.Location = new System.Drawing.Point(436, 125);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(63, 16);
            this.chkRepeat.TabIndex = 22;
            this.chkRepeat.Text = "Repeat";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMainDCTestOff);
            this.groupBox1.Controls.Add(this.btnMainDCepos);
            this.groupBox1.Controls.Add(this.btnMainDCTestOn);
            this.groupBox1.Controls.Add(this.btnMainDCHome);
            this.groupBox1.Controls.Add(this.btnMainDCHold);
            this.groupBox1.Controls.Add(this.btnMainDCspos);
            this.groupBox1.Location = new System.Drawing.Point(10, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 49);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MainDC";
            // 
            // btnMainDCTestOff
            // 
            this.btnMainDCTestOff.Location = new System.Drawing.Point(422, 16);
            this.btnMainDCTestOff.Name = "btnMainDCTestOff";
            this.btnMainDCTestOff.Size = new System.Drawing.Size(75, 23);
            this.btnMainDCTestOff.TabIndex = 26;
            this.btnMainDCTestOff.Text = "TestOff";
            this.btnMainDCTestOff.UseVisualStyleBackColor = true;
            this.btnMainDCTestOff.Click += new System.EventHandler(this.btnMainDCTestOff_Click);
            // 
            // btnMainDCepos
            // 
            this.btnMainDCepos.Location = new System.Drawing.Point(166, 16);
            this.btnMainDCepos.Name = "btnMainDCepos";
            this.btnMainDCepos.Size = new System.Drawing.Size(75, 23);
            this.btnMainDCepos.TabIndex = 26;
            this.btnMainDCepos.Text = "EPos.";
            this.btnMainDCepos.UseVisualStyleBackColor = true;
            this.btnMainDCepos.Click += new System.EventHandler(this.btnMainDCepos_Click);
            // 
            // btnMainDCTestOn
            // 
            this.btnMainDCTestOn.Location = new System.Drawing.Point(341, 16);
            this.btnMainDCTestOn.Name = "btnMainDCTestOn";
            this.btnMainDCTestOn.Size = new System.Drawing.Size(75, 23);
            this.btnMainDCTestOn.TabIndex = 25;
            this.btnMainDCTestOn.Text = "TestOn";
            this.btnMainDCTestOn.UseVisualStyleBackColor = true;
            this.btnMainDCTestOn.Click += new System.EventHandler(this.btnMainDCTestOn_Click);
            // 
            // btnMainDCHome
            // 
            this.btnMainDCHome.Location = new System.Drawing.Point(4, 16);
            this.btnMainDCHome.Name = "btnMainDCHome";
            this.btnMainDCHome.Size = new System.Drawing.Size(75, 23);
            this.btnMainDCHome.TabIndex = 24;
            this.btnMainDCHome.Text = "Home";
            this.btnMainDCHome.UseVisualStyleBackColor = true;
            this.btnMainDCHome.Click += new System.EventHandler(this.btnMainDCHome_Click);
            // 
            // btnMainDCHold
            // 
            this.btnMainDCHold.Location = new System.Drawing.Point(260, 16);
            this.btnMainDCHold.Name = "btnMainDCHold";
            this.btnMainDCHold.Size = new System.Drawing.Size(75, 23);
            this.btnMainDCHold.TabIndex = 24;
            this.btnMainDCHold.Text = "Hold";
            this.btnMainDCHold.UseVisualStyleBackColor = true;
            this.btnMainDCHold.Click += new System.EventHandler(this.btnMainDCHold_Click);
            // 
            // btnMainDCspos
            // 
            this.btnMainDCspos.Location = new System.Drawing.Point(85, 16);
            this.btnMainDCspos.Name = "btnMainDCspos";
            this.btnMainDCspos.Size = new System.Drawing.Size(75, 23);
            this.btnMainDCspos.TabIndex = 25;
            this.btnMainDCspos.Text = "SPos.";
            this.btnMainDCspos.UseVisualStyleBackColor = true;
            this.btnMainDCspos.Click += new System.EventHandler(this.btnMainDCspos_Click);
            // 
            // btnFANOnOff
            // 
            this.btnFANOnOff.Location = new System.Drawing.Point(95, 121);
            this.btnFANOnOff.Name = "btnFANOnOff";
            this.btnFANOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnFANOnOff.TabIndex = 24;
            this.btnFANOnOff.Text = "FAN On";
            this.btnFANOnOff.UseVisualStyleBackColor = true;
            this.btnFANOnOff.Click += new System.EventHandler(this.btnFANOnOff_Click);
            // 
            // chkSndAck
            // 
            this.chkSndAck.AutoSize = true;
            this.chkSndAck.Checked = true;
            this.chkSndAck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSndAck.Location = new System.Drawing.Point(432, 82);
            this.chkSndAck.Name = "chkSndAck";
            this.chkSndAck.Size = new System.Drawing.Size(78, 16);
            this.chkSndAck.TabIndex = 25;
            this.chkSndAck.Text = "Send Ack";
            this.chkSndAck.UseVisualStyleBackColor = true;
            // 
            // btnDipSW_Check
            // 
            this.btnDipSW_Check.Location = new System.Drawing.Point(14, 150);
            this.btnDipSW_Check.Name = "btnDipSW_Check";
            this.btnDipSW_Check.Size = new System.Drawing.Size(75, 23);
            this.btnDipSW_Check.TabIndex = 26;
            this.btnDipSW_Check.Text = "DIP SW";
            this.btnDipSW_Check.UseVisualStyleBackColor = true;
            this.btnDipSW_Check.Click += new System.EventHandler(this.btnDipSW_Check_Click);
            // 
            // txtDipSW_Target
            // 
            this.txtDipSW_Target.Location = new System.Drawing.Point(95, 150);
            this.txtDipSW_Target.Name = "txtDipSW_Target";
            this.txtDipSW_Target.Size = new System.Drawing.Size(75, 21);
            this.txtDipSW_Target.TabIndex = 27;
            this.txtDipSW_Target.Text = "1001";
            this.txtDipSW_Target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDipSW_Result
            // 
            this.txtDipSW_Result.Enabled = false;
            this.txtDipSW_Result.Location = new System.Drawing.Point(176, 150);
            this.txtDipSW_Result.Name = "txtDipSW_Result";
            this.txtDipSW_Result.Size = new System.Drawing.Size(75, 21);
            this.txtDipSW_Result.TabIndex = 28;
            this.txtDipSW_Result.Text = "None";
            this.txtDipSW_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSPI
            // 
            this.btnSPI.Location = new System.Drawing.Point(270, 150);
            this.btnSPI.Name = "btnSPI";
            this.btnSPI.Size = new System.Drawing.Size(75, 23);
            this.btnSPI.TabIndex = 29;
            this.btnSPI.Text = "SPI";
            this.btnSPI.UseVisualStyleBackColor = true;
            this.btnSPI.Click += new System.EventHandler(this.btnSPI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 581);
            this.Controls.Add(this.btnSPI);
            this.Controls.Add(this.txtDipSW_Result);
            this.Controls.Add(this.txtDipSW_Target);
            this.Controls.Add(this.btnDipSW_Check);
            this.Controls.Add(this.chkSndAck);
            this.Controls.Add(this.btnFANOnOff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkRepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDbgOn);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.btnSts);
            this.Controls.Add(this.btnZStop);
            this.Controls.Add(this.btnZCCW);
            this.Controls.Add(this.btnZCW);
            this.Controls.Add(this.btnYStop);
            this.Controls.Add(this.btnYCCW);
            this.Controls.Add(this.btnYCW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkSndHexa);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.chkRecHexa);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboPortName);
            this.Name = "FormMain";
            this.Text = "Serial Communication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.CheckBox chkRecHexa;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkSndHexa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYCW;
        private System.Windows.Forms.Button btnYCCW;
        private System.Windows.Forms.Button btnYStop;
        private System.Windows.Forms.Button btnZCW;
        private System.Windows.Forms.Button btnZCCW;
        private System.Windows.Forms.Button btnZStop;
        private System.Windows.Forms.Button btnSts;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnDbgOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMainDCTestOff;
        private System.Windows.Forms.Button btnMainDCepos;
        private System.Windows.Forms.Button btnMainDCTestOn;
        private System.Windows.Forms.Button btnMainDCHome;
        private System.Windows.Forms.Button btnMainDCHold;
        private System.Windows.Forms.Button btnMainDCspos;
        private System.Windows.Forms.Button btnFANOnOff;
        private System.Windows.Forms.CheckBox chkSndAck;
        private System.Windows.Forms.Button btnDipSW_Check;
        private System.Windows.Forms.TextBox txtDipSW_Target;
        private System.Windows.Forms.TextBox txtDipSW_Result;
        private System.Windows.Forms.Button btnSPI;
    }
}

