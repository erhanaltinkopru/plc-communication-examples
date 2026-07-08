namespace PlcCommunicationExamples
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpConnection = new GroupBox();
            lblCpu = new Label();
            cmbCpu = new ComboBox();
            lblIp = new Label();
            txtIp = new TextBox();
            lblRack = new Label();
            numRack = new NumericUpDown();
            lblSlot = new Label();
            numSlot = new NumericUpDown();
            btnConnect = new Button();
            btnDisconnect = new Button();
            lblStatus = new Label();
            grpOperations = new GroupBox();
            lblHeaderType = new Label();
            lblHeaderAddress = new Label();
            lblHeaderValue = new Label();
            lblWord = new Label();
            txtWordAddress = new TextBox();
            txtWordValue = new TextBox();
            btnWordRead = new Button();
            btnWordWrite = new Button();
            lblInt = new Label();
            txtIntAddress = new TextBox();
            txtIntValue = new TextBox();
            btnIntRead = new Button();
            btnIntWrite = new Button();
            lblDWord = new Label();
            txtDWordAddress = new TextBox();
            txtDWordValue = new TextBox();
            btnDWordRead = new Button();
            btnDWordWrite = new Button();
            lblDInt = new Label();
            txtDIntAddress = new TextBox();
            txtDIntValue = new TextBox();
            btnDIntRead = new Button();
            btnDIntWrite = new Button();
            lblReal = new Label();
            txtRealAddress = new TextBox();
            txtRealValue = new TextBox();
            btnRealRead = new Button();
            btnRealWrite = new Button();
            grpBitOperation = new GroupBox();
            lblByteAddress = new Label();
            txtByteAddress = new TextBox();
            lblBitIndex = new Label();
            numBitIndex = new NumericUpDown();
            btnBitRead = new Button();
            lblBitResult = new Label();
            grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSlot).BeginInit();
            grpOperations.SuspendLayout();
            grpBitOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBitIndex).BeginInit();
            SuspendLayout();
            // 
            // grpConnection
            // 
            grpConnection.Controls.Add(lblCpu);
            grpConnection.Controls.Add(cmbCpu);
            grpConnection.Controls.Add(lblIp);
            grpConnection.Controls.Add(txtIp);
            grpConnection.Controls.Add(lblRack);
            grpConnection.Controls.Add(numRack);
            grpConnection.Controls.Add(lblSlot);
            grpConnection.Controls.Add(numSlot);
            grpConnection.Controls.Add(btnConnect);
            grpConnection.Controls.Add(btnDisconnect);
            grpConnection.Controls.Add(lblStatus);
            grpConnection.Location = new Point(14, 16);
            grpConnection.Margin = new Padding(3, 4, 3, 4);
            grpConnection.Name = "grpConnection";
            grpConnection.Padding = new Padding(3, 4, 3, 4);
            grpConnection.Size = new Size(910, 133);
            grpConnection.TabIndex = 0;
            grpConnection.TabStop = false;
            grpConnection.Text = "PLC Bağlantı Ayarları";
            // 
            // lblCpu
            // 
            lblCpu.Location = new Point(17, 33);
            lblCpu.Name = "lblCpu";
            lblCpu.Size = new Size(69, 27);
            lblCpu.TabIndex = 0;
            lblCpu.Text = "CPU Tipi:";
            // 
            // cmbCpu
            // 
            cmbCpu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCpu.FormattingEnabled = true;
            cmbCpu.Items.AddRange(new object[] { "S71200", "S71500", "S7300", "S7400" });
            cmbCpu.Location = new Point(17, 64);
            cmbCpu.Margin = new Padding(3, 4, 3, 4);
            cmbCpu.Name = "cmbCpu";
            cmbCpu.Size = new Size(114, 28);
            cmbCpu.TabIndex = 1;
            // 
            // lblIp
            // 
            lblIp.Location = new Point(149, 33);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(91, 27);
            lblIp.TabIndex = 2;
            lblIp.Text = "IP Adresi:";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(149, 64);
            txtIp.Margin = new Padding(3, 4, 3, 4);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(125, 27);
            txtIp.TabIndex = 2;
            txtIp.Text = "192.168.0.1";
            // 
            // lblRack
            // 
            lblRack.Location = new Point(297, 33);
            lblRack.Name = "lblRack";
            lblRack.Size = new Size(46, 27);
            lblRack.TabIndex = 3;
            lblRack.Text = "Rack:";
            // 
            // numRack
            // 
            numRack.Location = new Point(297, 64);
            numRack.Margin = new Padding(3, 4, 3, 4);
            numRack.Name = "numRack";
            numRack.Size = new Size(57, 27);
            numRack.TabIndex = 3;
            // 
            // lblSlot
            // 
            lblSlot.Location = new Point(371, 33);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(46, 27);
            lblSlot.TabIndex = 4;
            lblSlot.Text = "Slot:";
            // 
            // numSlot
            // 
            numSlot.Location = new Point(371, 64);
            numSlot.Margin = new Padding(3, 4, 3, 4);
            numSlot.Name = "numSlot";
            numSlot.Size = new Size(57, 27);
            numSlot.TabIndex = 4;
            numSlot.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(617, 59);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(91, 40);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Bağlan";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(720, 59);
            btnDisconnect.Margin = new Padding(3, 4, 3, 4);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(114, 40);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.Text = "Bağlantıyı Kes";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(617, 27);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(217, 27);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Durum: Bağlantı Yok";
            // 
            // grpOperations
            // 
            grpOperations.Controls.Add(lblHeaderType);
            grpOperations.Controls.Add(lblHeaderAddress);
            grpOperations.Controls.Add(lblHeaderValue);
            grpOperations.Controls.Add(lblWord);
            grpOperations.Controls.Add(txtWordAddress);
            grpOperations.Controls.Add(txtWordValue);
            grpOperations.Controls.Add(btnWordRead);
            grpOperations.Controls.Add(btnWordWrite);
            grpOperations.Controls.Add(lblInt);
            grpOperations.Controls.Add(txtIntAddress);
            grpOperations.Controls.Add(txtIntValue);
            grpOperations.Controls.Add(btnIntRead);
            grpOperations.Controls.Add(btnIntWrite);
            grpOperations.Controls.Add(lblDWord);
            grpOperations.Controls.Add(txtDWordAddress);
            grpOperations.Controls.Add(txtDWordValue);
            grpOperations.Controls.Add(btnDWordRead);
            grpOperations.Controls.Add(btnDWordWrite);
            grpOperations.Controls.Add(lblDInt);
            grpOperations.Controls.Add(txtDIntAddress);
            grpOperations.Controls.Add(txtDIntValue);
            grpOperations.Controls.Add(btnDIntRead);
            grpOperations.Controls.Add(btnDIntWrite);
            grpOperations.Controls.Add(lblReal);
            grpOperations.Controls.Add(txtRealAddress);
            grpOperations.Controls.Add(txtRealValue);
            grpOperations.Controls.Add(btnRealRead);
            grpOperations.Controls.Add(btnRealWrite);
            grpOperations.Location = new Point(14, 167);
            grpOperations.Margin = new Padding(3, 4, 3, 4);
            grpOperations.Name = "grpOperations";
            grpOperations.Padding = new Padding(3, 4, 3, 4);
            grpOperations.Size = new Size(910, 400);
            grpOperations.TabIndex = 9;
            grpOperations.TabStop = false;
            grpOperations.Text = "PLC Veri Okuma / Yazma İşlemleri";
            // 
            // lblHeaderType
            // 
            lblHeaderType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeaderType.Location = new Point(17, 33);
            lblHeaderType.Name = "lblHeaderType";
            lblHeaderType.Size = new Size(171, 27);
            lblHeaderType.TabIndex = 0;
            lblHeaderType.Text = "Veri Tipi";
            // 
            // lblHeaderAddress
            // 
            lblHeaderAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeaderAddress.Location = new Point(206, 33);
            lblHeaderAddress.Name = "lblHeaderAddress";
            lblHeaderAddress.Size = new Size(137, 27);
            lblHeaderAddress.TabIndex = 1;
            lblHeaderAddress.Text = "PLC Adresi";
            // 
            // lblHeaderValue
            // 
            lblHeaderValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeaderValue.Location = new Point(366, 33);
            lblHeaderValue.Name = "lblHeaderValue";
            lblHeaderValue.Size = new Size(171, 27);
            lblHeaderValue.TabIndex = 2;
            lblHeaderValue.Text = "Değer";
            // 
            // lblWord
            // 
            lblWord.Location = new Point(17, 80);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(171, 27);
            lblWord.TabIndex = 3;
            lblWord.Text = "S7 Word (ushort - 16 bit):";
            // 
            // txtWordAddress
            // 
            txtWordAddress.Location = new Point(206, 77);
            txtWordAddress.Margin = new Padding(3, 4, 3, 4);
            txtWordAddress.Name = "txtWordAddress";
            txtWordAddress.Size = new Size(137, 27);
            txtWordAddress.TabIndex = 10;
            txtWordAddress.Text = "DB1.DBW0";
            // 
            // txtWordValue
            // 
            txtWordValue.Location = new Point(366, 77);
            txtWordValue.Margin = new Padding(3, 4, 3, 4);
            txtWordValue.Name = "txtWordValue";
            txtWordValue.Size = new Size(171, 27);
            txtWordValue.TabIndex = 11;
            // 
            // btnWordRead
            // 
            btnWordRead.Location = new Point(560, 73);
            btnWordRead.Margin = new Padding(3, 4, 3, 4);
            btnWordRead.Name = "btnWordRead";
            btnWordRead.Size = new Size(86, 37);
            btnWordRead.TabIndex = 12;
            btnWordRead.Text = "Oku";
            btnWordRead.UseVisualStyleBackColor = true;
            btnWordRead.Click += btnWordRead_Click;
            // 
            // btnWordWrite
            // 
            btnWordWrite.Location = new Point(657, 73);
            btnWordWrite.Margin = new Padding(3, 4, 3, 4);
            btnWordWrite.Name = "btnWordWrite";
            btnWordWrite.Size = new Size(86, 37);
            btnWordWrite.TabIndex = 13;
            btnWordWrite.Text = "Yaz";
            btnWordWrite.UseVisualStyleBackColor = true;
            btnWordWrite.Click += btnWordWrite_Click;
            // 
            // lblInt
            // 
            lblInt.Location = new Point(17, 140);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(171, 27);
            lblInt.TabIndex = 14;
            lblInt.Text = "S7 Int / Dec (short - 16 bit):";
            // 
            // txtIntAddress
            // 
            txtIntAddress.Location = new Point(206, 137);
            txtIntAddress.Margin = new Padding(3, 4, 3, 4);
            txtIntAddress.Name = "txtIntAddress";
            txtIntAddress.Size = new Size(137, 27);
            txtIntAddress.TabIndex = 14;
            txtIntAddress.Text = "DB1.DBW2";
            // 
            // txtIntValue
            // 
            txtIntValue.Location = new Point(366, 137);
            txtIntValue.Margin = new Padding(3, 4, 3, 4);
            txtIntValue.Name = "txtIntValue";
            txtIntValue.Size = new Size(171, 27);
            txtIntValue.TabIndex = 15;
            // 
            // btnIntRead
            // 
            btnIntRead.Location = new Point(560, 133);
            btnIntRead.Margin = new Padding(3, 4, 3, 4);
            btnIntRead.Name = "btnIntRead";
            btnIntRead.Size = new Size(86, 37);
            btnIntRead.TabIndex = 16;
            btnIntRead.Text = "Oku";
            btnIntRead.UseVisualStyleBackColor = true;
            btnIntRead.Click += btnIntRead_Click;
            // 
            // btnIntWrite
            // 
            btnIntWrite.Location = new Point(657, 133);
            btnIntWrite.Margin = new Padding(3, 4, 3, 4);
            btnIntWrite.Name = "btnIntWrite";
            btnIntWrite.Size = new Size(86, 37);
            btnIntWrite.TabIndex = 17;
            btnIntWrite.Text = "Yaz";
            btnIntWrite.UseVisualStyleBackColor = true;
            btnIntWrite.Click += btnIntWrite_Click;
            // 
            // lblDWord
            // 
            lblDWord.Location = new Point(17, 200);
            lblDWord.Name = "lblDWord";
            lblDWord.Size = new Size(171, 27);
            lblDWord.TabIndex = 18;
            lblDWord.Text = "S7 DWord (uint - 32 bit):";
            // 
            // txtDWordAddress
            // 
            txtDWordAddress.Location = new Point(206, 197);
            txtDWordAddress.Margin = new Padding(3, 4, 3, 4);
            txtDWordAddress.Name = "txtDWordAddress";
            txtDWordAddress.Size = new Size(137, 27);
            txtDWordAddress.TabIndex = 18;
            txtDWordAddress.Text = "DB1.DBD4";
            // 
            // txtDWordValue
            // 
            txtDWordValue.Location = new Point(366, 197);
            txtDWordValue.Margin = new Padding(3, 4, 3, 4);
            txtDWordValue.Name = "txtDWordValue";
            txtDWordValue.Size = new Size(171, 27);
            txtDWordValue.TabIndex = 19;
            // 
            // btnDWordRead
            // 
            btnDWordRead.Location = new Point(560, 193);
            btnDWordRead.Margin = new Padding(3, 4, 3, 4);
            btnDWordRead.Name = "btnDWordRead";
            btnDWordRead.Size = new Size(86, 37);
            btnDWordRead.TabIndex = 20;
            btnDWordRead.Text = "Oku";
            btnDWordRead.UseVisualStyleBackColor = true;
            btnDWordRead.Click += btnDWordRead_Click;
            // 
            // btnDWordWrite
            // 
            btnDWordWrite.Location = new Point(657, 193);
            btnDWordWrite.Margin = new Padding(3, 4, 3, 4);
            btnDWordWrite.Name = "btnDWordWrite";
            btnDWordWrite.Size = new Size(86, 37);
            btnDWordWrite.TabIndex = 21;
            btnDWordWrite.Text = "Yaz";
            btnDWordWrite.UseVisualStyleBackColor = true;
            btnDWordWrite.Click += btnDWordWrite_Click;
            // 
            // lblDInt
            // 
            lblDInt.Location = new Point(17, 260);
            lblDInt.Name = "lblDInt";
            lblDInt.Size = new Size(171, 27);
            lblDInt.TabIndex = 22;
            lblDInt.Text = "S7 DInt (int - 32 bit):";
            // 
            // txtDIntAddress
            // 
            txtDIntAddress.Location = new Point(206, 257);
            txtDIntAddress.Margin = new Padding(3, 4, 3, 4);
            txtDIntAddress.Name = "txtDIntAddress";
            txtDIntAddress.Size = new Size(137, 27);
            txtDIntAddress.TabIndex = 22;
            txtDIntAddress.Text = "DB1.DBD8";
            // 
            // txtDIntValue
            // 
            txtDIntValue.Location = new Point(366, 257);
            txtDIntValue.Margin = new Padding(3, 4, 3, 4);
            txtDIntValue.Name = "txtDIntValue";
            txtDIntValue.Size = new Size(171, 27);
            txtDIntValue.TabIndex = 23;
            // 
            // btnDIntRead
            // 
            btnDIntRead.Location = new Point(560, 253);
            btnDIntRead.Margin = new Padding(3, 4, 3, 4);
            btnDIntRead.Name = "btnDIntRead";
            btnDIntRead.Size = new Size(86, 37);
            btnDIntRead.TabIndex = 24;
            btnDIntRead.Text = "Oku";
            btnDIntRead.UseVisualStyleBackColor = true;
            btnDIntRead.Click += btnDIntRead_Click;
            // 
            // btnDIntWrite
            // 
            btnDIntWrite.Location = new Point(657, 253);
            btnDIntWrite.Margin = new Padding(3, 4, 3, 4);
            btnDIntWrite.Name = "btnDIntWrite";
            btnDIntWrite.Size = new Size(86, 37);
            btnDIntWrite.TabIndex = 25;
            btnDIntWrite.Text = "Yaz";
            btnDIntWrite.UseVisualStyleBackColor = true;
            btnDIntWrite.Click += btnDIntWrite_Click;
            // 
            // lblReal
            // 
            lblReal.Location = new Point(17, 320);
            lblReal.Name = "lblReal";
            lblReal.Size = new Size(171, 27);
            lblReal.TabIndex = 26;
            lblReal.Text = "S7 Real (double - 32 bit):";
            // 
            // txtRealAddress
            // 
            txtRealAddress.Location = new Point(206, 317);
            txtRealAddress.Margin = new Padding(3, 4, 3, 4);
            txtRealAddress.Name = "txtRealAddress";
            txtRealAddress.Size = new Size(137, 27);
            txtRealAddress.TabIndex = 26;
            txtRealAddress.Text = "DB1.DBD12";
            // 
            // txtRealValue
            // 
            txtRealValue.Location = new Point(366, 317);
            txtRealValue.Margin = new Padding(3, 4, 3, 4);
            txtRealValue.Name = "txtRealValue";
            txtRealValue.Size = new Size(171, 27);
            txtRealValue.TabIndex = 27;
            // 
            // btnRealRead
            // 
            btnRealRead.Location = new Point(560, 313);
            btnRealRead.Margin = new Padding(3, 4, 3, 4);
            btnRealRead.Name = "btnRealRead";
            btnRealRead.Size = new Size(86, 37);
            btnRealRead.TabIndex = 28;
            btnRealRead.Text = "Oku";
            btnRealRead.UseVisualStyleBackColor = true;
            btnRealRead.Click += btnRealRead_Click;
            // 
            // btnRealWrite
            // 
            btnRealWrite.Location = new Point(657, 313);
            btnRealWrite.Margin = new Padding(3, 4, 3, 4);
            btnRealWrite.Name = "btnRealWrite";
            btnRealWrite.Size = new Size(86, 37);
            btnRealWrite.TabIndex = 29;
            btnRealWrite.Text = "Yaz";
            btnRealWrite.UseVisualStyleBackColor = true;
            btnRealWrite.Click += btnRealWrite_Click;
            // 
            // grpBitOperation
            // 
            grpBitOperation.Controls.Add(lblByteAddress);
            grpBitOperation.Controls.Add(txtByteAddress);
            grpBitOperation.Controls.Add(lblBitIndex);
            grpBitOperation.Controls.Add(numBitIndex);
            grpBitOperation.Controls.Add(btnBitRead);
            grpBitOperation.Controls.Add(lblBitResult);
            grpBitOperation.Location = new Point(14, 587);
            grpBitOperation.Margin = new Padding(3, 4, 3, 4);
            grpBitOperation.Name = "grpBitOperation";
            grpBitOperation.Padding = new Padding(3, 4, 3, 4);
            grpBitOperation.Size = new Size(910, 113);
            grpBitOperation.TabIndex = 30;
            grpBitOperation.TabStop = false;
            grpBitOperation.Text = "Byte İçerisinden Bit (Boolean) Okuma";
            // 
            // lblByteAddress
            // 
            lblByteAddress.Location = new Point(17, 47);
            lblByteAddress.Name = "lblByteAddress";
            lblByteAddress.Size = new Size(91, 27);
            lblByteAddress.TabIndex = 0;
            lblByteAddress.Text = "Byte Adresi:";
            // 
            // txtByteAddress
            // 
            txtByteAddress.Location = new Point(114, 43);
            txtByteAddress.Margin = new Padding(3, 4, 3, 4);
            txtByteAddress.Name = "txtByteAddress";
            txtByteAddress.Size = new Size(137, 27);
            txtByteAddress.TabIndex = 31;
            txtByteAddress.Text = "DB1.DBB16";
            // 
            // lblBitIndex
            // 
            lblBitIndex.Location = new Point(274, 47);
            lblBitIndex.Name = "lblBitIndex";
            lblBitIndex.Size = new Size(114, 27);
            lblBitIndex.TabIndex = 32;
            lblBitIndex.Text = "Bit İndeksi (0-7):";
            // 
            // numBitIndex
            // 
            numBitIndex.Location = new Point(389, 43);
            numBitIndex.Margin = new Padding(3, 4, 3, 4);
            numBitIndex.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numBitIndex.Name = "numBitIndex";
            numBitIndex.Size = new Size(57, 27);
            numBitIndex.TabIndex = 32;
            // 
            // btnBitRead
            // 
            btnBitRead.Location = new Point(480, 39);
            btnBitRead.Margin = new Padding(3, 4, 3, 4);
            btnBitRead.Name = "btnBitRead";
            btnBitRead.Size = new Size(126, 37);
            btnBitRead.TabIndex = 33;
            btnBitRead.Text = "Bit Durumu Oku";
            btnBitRead.UseVisualStyleBackColor = true;
            btnBitRead.Click += btnBitRead_Click;
            // 
            // lblBitResult
            // 
            lblBitResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBitResult.Location = new Point(629, 44);
            lblBitResult.Name = "lblBitResult";
            lblBitResult.Size = new Size(229, 27);
            lblBitResult.TabIndex = 34;
            lblBitResult.Text = "Bit Sonucu: -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 727);
            Controls.Add(grpBitOperation);
            Controls.Add(grpOperations);
            Controls.Add(grpConnection);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PLC S7.Net Veri Okuma / Yazma ve Dönüşüm Kılavuzu";
            grpConnection.ResumeLayout(false);
            grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSlot).EndInit();
            grpOperations.ResumeLayout(false);
            grpOperations.PerformLayout();
            grpBitOperation.ResumeLayout(false);
            grpBitOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBitIndex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.ComboBox cmbCpu;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.NumericUpDown numRack;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.NumericUpDown numSlot;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Label lblHeaderType;
        private System.Windows.Forms.Label lblHeaderAddress;
        private System.Windows.Forms.Label lblHeaderValue;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWordAddress;
        private System.Windows.Forms.TextBox txtWordValue;
        private System.Windows.Forms.Button btnWordRead;
        private System.Windows.Forms.Button btnWordWrite;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.TextBox txtIntAddress;
        private System.Windows.Forms.TextBox txtIntValue;
        private System.Windows.Forms.Button btnIntRead;
        private System.Windows.Forms.Button btnIntWrite;
        private System.Windows.Forms.Label lblDWord;
        private System.Windows.Forms.TextBox txtDWordAddress;
        private System.Windows.Forms.TextBox txtDWordValue;
        private System.Windows.Forms.Button btnDWordRead;
        private System.Windows.Forms.Button btnDWordWrite;
        private System.Windows.Forms.Label lblDInt;
        private System.Windows.Forms.TextBox txtDIntAddress;
        private System.Windows.Forms.TextBox txtDIntValue;
        private System.Windows.Forms.Button btnDIntRead;
        private System.Windows.Forms.Button btnDIntWrite;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.TextBox txtRealAddress;
        private System.Windows.Forms.TextBox txtRealValue;
        private System.Windows.Forms.Button btnRealRead;
        private System.Windows.Forms.Button btnRealWrite;
        private System.Windows.Forms.GroupBox grpBitOperation;
        private System.Windows.Forms.Label lblByteAddress;
        private System.Windows.Forms.TextBox txtByteAddress;
        private System.Windows.Forms.Label lblBitIndex;
        private System.Windows.Forms.NumericUpDown numBitIndex;
        private System.Windows.Forms.Button btnBitRead;
        private System.Windows.Forms.Label lblBitResult;
    }
}
