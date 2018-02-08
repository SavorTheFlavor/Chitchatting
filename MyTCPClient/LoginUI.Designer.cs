namespace MyTCPClient {
    partial class LoginUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.serverIpTxtBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.connectBtn = new CCWin.SkinControl.SkinButton();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.profilelabel = new System.Windows.Forms.Label();
            this.changeProfile = new CCWin.SkinControl.SkinButton();
            this.individualWords = new System.Windows.Forms.RichTextBox();
            this.swLabel = new System.Windows.Forms.Label();
            this.serverIptxbPanel = new System.Windows.Forms.Panel();
            this.porttxbPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // serverIpTxtBox
            // 
            this.serverIpTxtBox.Enabled = false;
            this.serverIpTxtBox.Location = new System.Drawing.Point(131, 110);
            this.serverIpTxtBox.Name = "serverIpTxtBox";
            this.serverIpTxtBox.Size = new System.Drawing.Size(168, 21);
            this.serverIpTxtBox.TabIndex = 0;
            this.serverIpTxtBox.Text = "localhost";
            // 
            // portTextBox
            // 
            this.portTextBox.Enabled = false;
            this.portTextBox.Location = new System.Drawing.Point(131, 153);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(168, 21);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "12345";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(131, 194);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(168, 21);
            this.usernameTxtBox.TabIndex = 2;
            this.usernameTxtBox.TextChanged += new System.EventHandler(this.usernameTxtBox_TextChanged);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(84, 113);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(41, 12);
            this.serverLabel.TabIndex = 3;
            this.serverLabel.Text = "server";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(84, 156);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 12);
            this.portLabel.TabIndex = 4;
            this.portLabel.Text = "port";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(72, 197);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 12);
            this.username.TabIndex = 5;
            this.username.Text = "username";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Transparent;
            this.connectBtn.BaseColor = System.Drawing.Color.Gray;
            this.connectBtn.BorderColor = System.Drawing.Color.Gray;
            this.connectBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.connectBtn.DownBack = null;
            this.connectBtn.Location = new System.Drawing.Point(248, 250);
            this.connectBtn.MouseBack = null;
            this.connectBtn.MouseBaseColor = System.Drawing.Color.Silver;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.NormlBack = null;
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // profileImg
            // 
            this.profileImg.Image = global::MyTCPClient.Properties.Resources.hush;
            this.profileImg.Location = new System.Drawing.Point(352, 138);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(67, 54);
            this.profileImg.TabIndex = 7;
            this.profileImg.TabStop = false;
            // 
            // profilelabel
            // 
            this.profilelabel.AutoSize = true;
            this.profilelabel.Location = new System.Drawing.Point(350, 112);
            this.profilelabel.Name = "profilelabel";
            this.profilelabel.Size = new System.Drawing.Size(77, 12);
            this.profilelabel.TabIndex = 8;
            this.profilelabel.Text = "your profile";
            // 
            // changeProfile
            // 
            this.changeProfile.BackColor = System.Drawing.Color.Transparent;
            this.changeProfile.BaseColor = System.Drawing.Color.Silver;
            this.changeProfile.BorderColor = System.Drawing.Color.Silver;
            this.changeProfile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.changeProfile.DownBack = null;
            this.changeProfile.Location = new System.Drawing.Point(352, 198);
            this.changeProfile.MouseBack = null;
            this.changeProfile.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeProfile.Name = "changeProfile";
            this.changeProfile.NormlBack = null;
            this.changeProfile.Size = new System.Drawing.Size(67, 23);
            this.changeProfile.TabIndex = 9;
            this.changeProfile.Text = "change";
            this.changeProfile.UseVisualStyleBackColor = false;
            this.changeProfile.Click += new System.EventHandler(this.changeProfile_Click);
            // 
            // individualWords
            // 
            this.individualWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.individualWords.Location = new System.Drawing.Point(446, 138);
            this.individualWords.Name = "individualWords";
            this.individualWords.Size = new System.Drawing.Size(67, 54);
            this.individualWords.TabIndex = 10;
            this.individualWords.Text = "................";
            // 
            // swLabel
            // 
            this.swLabel.AutoSize = true;
            this.swLabel.Location = new System.Drawing.Point(444, 113);
            this.swLabel.Name = "swLabel";
            this.swLabel.Size = new System.Drawing.Size(65, 12);
            this.swLabel.TabIndex = 12;
            this.swLabel.Text = "some words";
            // 
            // serverIptxbPanel
            // 
            this.serverIptxbPanel.Location = new System.Drawing.Point(131, 101);
            this.serverIptxbPanel.Name = "serverIptxbPanel";
            this.serverIptxbPanel.Size = new System.Drawing.Size(168, 31);
            this.serverIptxbPanel.TabIndex = 13;
            this.serverIptxbPanel.MouseHover += new System.EventHandler(this.serverIptxbPanel_MouseHover);
            // 
            // porttxbPanel
            // 
            this.porttxbPanel.Location = new System.Drawing.Point(131, 153);
            this.porttxbPanel.Name = "porttxbPanel";
            this.porttxbPanel.Size = new System.Drawing.Size(168, 21);
            this.porttxbPanel.TabIndex = 14;
            this.porttxbPanel.MouseHover += new System.EventHandler(this.porttxbPanel_MouseHover);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 363);
            this.Controls.Add(this.swLabel);
            this.Controls.Add(this.individualWords);
            this.Controls.Add(this.changeProfile);
            this.Controls.Add(this.profilelabel);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.serverIpTxtBox);
            this.Controls.Add(this.serverIptxbPanel);
            this.Controls.Add(this.porttxbPanel);
            this.Name = "LoginUI";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.Click += new System.EventHandler(this.LoginUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIpTxtBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label username;
        private CCWin.SkinControl.SkinButton connectBtn;
        private System.Windows.Forms.PictureBox profileImg;
        private System.Windows.Forms.Label profilelabel;
        private CCWin.SkinControl.SkinButton changeProfile;
        private System.Windows.Forms.RichTextBox individualWords;
        private System.Windows.Forms.Label swLabel;
        private System.Windows.Forms.Panel serverIptxbPanel;
        private System.Windows.Forms.Panel porttxbPanel;
    }
}