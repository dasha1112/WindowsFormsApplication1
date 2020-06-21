namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TIBCOServerName = new System.Windows.Forms.TextBox();
            this.TIBCOServerName_label = new System.Windows.Forms.Label();
            this.TIBCOServerPort_label = new System.Windows.Forms.Label();
            this.TIBCOServerPort = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnMsgSend = new System.Windows.Forms.Button();
            this.SendMsgTextBox = new System.Windows.Forms.TextBox();
            this.ReceveMsgTextBox = new System.Windows.Forms.TextBox();
            this.TIBCO_EMS_Queue_Receve = new System.Windows.Forms.TextBox();
            this.TIBCO_EMS_Queue_Send_label = new System.Windows.Forms.Label();
            this.TIBCO_EMS_Queue_Send = new System.Windows.Forms.TextBox();
            this.TIBCO_EMS_Queue_Receve_label = new System.Windows.Forms.Label();
            this.MesageReceveLabel = new System.Windows.Forms.Label();
            this.MesageSendLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TIBCOServerName
            // 
            this.TIBCOServerName.Location = new System.Drawing.Point(122, 12);
            this.TIBCOServerName.Name = "TIBCOServerName";
            this.TIBCOServerName.Size = new System.Drawing.Size(168, 20);
            this.TIBCOServerName.TabIndex = 0;
            this.TIBCOServerName.Text = "localhost";
            // 
            // TIBCOServerName_label
            // 
            this.TIBCOServerName_label.AutoSize = true;
            this.TIBCOServerName_label.Location = new System.Drawing.Point(12, 15);
            this.TIBCOServerName_label.Name = "TIBCOServerName_label";
            this.TIBCOServerName_label.Size = new System.Drawing.Size(104, 13);
            this.TIBCOServerName_label.TabIndex = 1;
            this.TIBCOServerName_label.Text = "TIBCO Server Name";
            // 
            // TIBCOServerPort_label
            // 
            this.TIBCOServerPort_label.AutoSize = true;
            this.TIBCOServerPort_label.Location = new System.Drawing.Point(296, 15);
            this.TIBCOServerPort_label.Name = "TIBCOServerPort_label";
            this.TIBCOServerPort_label.Size = new System.Drawing.Size(95, 13);
            this.TIBCOServerPort_label.TabIndex = 2;
            this.TIBCOServerPort_label.Text = "TIBCO Server Port";
            // 
            // TIBCOServerPort
            // 
            this.TIBCOServerPort.Location = new System.Drawing.Point(397, 12);
            this.TIBCOServerPort.Name = "TIBCOServerPort";
            this.TIBCOServerPort.Size = new System.Drawing.Size(46, 20);
            this.TIBCOServerPort.TabIndex = 3;
            this.TIBCOServerPort.Text = "7222";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(15, 128);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(60, 24);
            this.BtnConnect.TabIndex = 4;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(81, 128);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(77, 24);
            this.BtnDisconnect.TabIndex = 5;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnMsgSend
            // 
            this.BtnMsgSend.Location = new System.Drawing.Point(446, 171);
            this.BtnMsgSend.Name = "BtnMsgSend";
            this.BtnMsgSend.Size = new System.Drawing.Size(60, 24);
            this.BtnMsgSend.TabIndex = 6;
            this.BtnMsgSend.Text = "Send";
            this.BtnMsgSend.UseVisualStyleBackColor = true;
            this.BtnMsgSend.Click += new System.EventHandler(this.BtnMsgSend_Click);
            // 
            // SendMsgTextBox
            // 
            this.SendMsgTextBox.Location = new System.Drawing.Point(94, 174);
            this.SendMsgTextBox.Name = "SendMsgTextBox";
            this.SendMsgTextBox.Size = new System.Drawing.Size(346, 20);
            this.SendMsgTextBox.TabIndex = 7;
            this.SendMsgTextBox.Text = "100500;666;123467890;123467890;16Х18Н24Т;9000.999;699.99;219.0;10.0;1;31-12-2017 " +
    "08:06:10.997;";
            // 
            // ReceveMsgTextBox
            // 
            this.ReceveMsgTextBox.Location = new System.Drawing.Point(94, 209);
            this.ReceveMsgTextBox.Name = "ReceveMsgTextBox";
            this.ReceveMsgTextBox.Size = new System.Drawing.Size(346, 20);
            this.ReceveMsgTextBox.TabIndex = 8;
            // 
            // TIBCO_EMS_Queue_Receve
            // 
            this.TIBCO_EMS_Queue_Receve.Location = new System.Drawing.Point(159, 95);
            this.TIBCO_EMS_Queue_Receve.Name = "TIBCO_EMS_Queue_Receve";
            this.TIBCO_EMS_Queue_Receve.Size = new System.Drawing.Size(321, 20);
            this.TIBCO_EMS_Queue_Receve.TabIndex = 10;
            this.TIBCO_EMS_Queue_Receve.TextChanged += new System.EventHandler(this.TIBCO_EMS_Queue_TextChanged);
            // 
            // TIBCO_EMS_Queue_Send_label
            // 
            this.TIBCO_EMS_Queue_Send_label.AutoSize = true;
            this.TIBCO_EMS_Queue_Send_label.Location = new System.Drawing.Point(12, 72);
            this.TIBCO_EMS_Queue_Send_label.Name = "TIBCO_EMS_Queue_Send_label";
            this.TIBCO_EMS_Queue_Send_label.Size = new System.Drawing.Size(128, 13);
            this.TIBCO_EMS_Queue_Send_label.TabIndex = 9;
            this.TIBCO_EMS_Queue_Send_label.Text = "TIBCO EMS Queue Send";
            // 
            // TIBCO_EMS_Queue_Send
            // 
            this.TIBCO_EMS_Queue_Send.Location = new System.Drawing.Point(159, 69);
            this.TIBCO_EMS_Queue_Send.Name = "TIBCO_EMS_Queue_Send";
            this.TIBCO_EMS_Queue_Send.Size = new System.Drawing.Size(321, 20);
            this.TIBCO_EMS_Queue_Send.TabIndex = 12;
            // 
            // TIBCO_EMS_Queue_Receve_label
            // 
            this.TIBCO_EMS_Queue_Receve_label.AutoSize = true;
            this.TIBCO_EMS_Queue_Receve_label.Location = new System.Drawing.Point(12, 98);
            this.TIBCO_EMS_Queue_Receve_label.Name = "TIBCO_EMS_Queue_Receve_label";
            this.TIBCO_EMS_Queue_Receve_label.Size = new System.Drawing.Size(141, 13);
            this.TIBCO_EMS_Queue_Receve_label.TabIndex = 11;
            this.TIBCO_EMS_Queue_Receve_label.Text = "TIBCO EMS Queue Receve";
            // 
            // MesageReceveLabel
            // 
            this.MesageReceveLabel.AutoSize = true;
            this.MesageReceveLabel.Location = new System.Drawing.Point(2, 212);
            this.MesageReceveLabel.Name = "MesageReceveLabel";
            this.MesageReceveLabel.Size = new System.Drawing.Size(86, 13);
            this.MesageReceveLabel.TabIndex = 14;
            this.MesageReceveLabel.Text = "Mesage Receve";
            // 
            // MesageSendLabel
            // 
            this.MesageSendLabel.AutoSize = true;
            this.MesageSendLabel.Location = new System.Drawing.Point(2, 177);
            this.MesageSendLabel.Name = "MesageSendLabel";
            this.MesageSendLabel.Size = new System.Drawing.Size(73, 13);
            this.MesageSendLabel.TabIndex = 13;
            this.MesageSendLabel.Text = "Mesage Send";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(87, 41);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(29, 13);
            this.UserLabel.TabIndex = 16;
            this.UserLabel.Text = "User";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(122, 38);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(93, 20);
            this.UserTextBox.TabIndex = 15;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(227, 41);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(286, 38);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(93, 20);
            this.PasswordTextBox.TabIndex = 17;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTextBox.ForeColor = System.Drawing.Color.Lime;
            this.LogTextBox.Location = new System.Drawing.Point(5, 240);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(507, 137);
            this.LogTextBox.TabIndex = 19;
            this.LogTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 382);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.MesageReceveLabel);
            this.Controls.Add(this.MesageSendLabel);
            this.Controls.Add(this.TIBCO_EMS_Queue_Send);
            this.Controls.Add(this.TIBCO_EMS_Queue_Receve_label);
            this.Controls.Add(this.TIBCO_EMS_Queue_Receve);
            this.Controls.Add(this.TIBCO_EMS_Queue_Send_label);
            this.Controls.Add(this.ReceveMsgTextBox);
            this.Controls.Add(this.SendMsgTextBox);
            this.Controls.Add(this.BtnMsgSend);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TIBCOServerPort);
            this.Controls.Add(this.TIBCOServerPort_label);
            this.Controls.Add(this.TIBCOServerName_label);
            this.Controls.Add(this.TIBCOServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TestTIBCO EMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TIBCOServerName;
        private System.Windows.Forms.Label TIBCOServerName_label;
        private System.Windows.Forms.Label TIBCOServerPort_label;
        private System.Windows.Forms.TextBox TIBCOServerPort;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnMsgSend;
        private System.Windows.Forms.TextBox SendMsgTextBox;
        private System.Windows.Forms.TextBox ReceveMsgTextBox;
        private System.Windows.Forms.TextBox TIBCO_EMS_Queue_Receve;
        private System.Windows.Forms.Label TIBCO_EMS_Queue_Send_label;
        private System.Windows.Forms.TextBox TIBCO_EMS_Queue_Send;
        private System.Windows.Forms.Label TIBCO_EMS_Queue_Receve_label;
        private System.Windows.Forms.Label MesageReceveLabel;
        private System.Windows.Forms.Label MesageSendLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.RichTextBox LogTextBox;
    }
}

