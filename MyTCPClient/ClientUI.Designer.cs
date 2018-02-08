namespace MyTCPClient {
    partial class ClientUI {
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
            this.operatePanel = new CCWin.SkinControl.SkinPanel();
            this.sendBtn = new CCWin.SkinControl.SkinButton();
            this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.onlineListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // operatePanel
            // 
            this.operatePanel.BackColor = System.Drawing.Color.Transparent;
            this.operatePanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.operatePanel.DownBack = null;
            this.operatePanel.Location = new System.Drawing.Point(130, 367);
            this.operatePanel.MouseBack = null;
            this.operatePanel.Name = "operatePanel";
            this.operatePanel.NormlBack = null;
            this.operatePanel.Size = new System.Drawing.Size(712, 28);
            this.operatePanel.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.BaseColor = System.Drawing.Color.Silver;
            this.sendBtn.BorderColor = System.Drawing.Color.Silver;
            this.sendBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sendBtn.DownBack = null;
            this.sendBtn.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sendBtn.Location = new System.Drawing.Point(761, 472);
            this.sendBtn.MouseBack = null;
            this.sendBtn.MouseBaseColor = System.Drawing.Color.Gray;
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.NormlBack = null;
            this.sendBtn.Size = new System.Drawing.Size(81, 31);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Location = new System.Drawing.Point(169, 35);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(673, 332);
            this.contentPanel.TabIndex = 4;
            this.contentPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.contentPanel_ControlAdded_1);
            // 
            // onlineListPanel
            // 
            this.onlineListPanel.BackColor = System.Drawing.Color.LightGray;
            this.onlineListPanel.Location = new System.Drawing.Point(0, 28);
            this.onlineListPanel.Name = "onlineListPanel";
            this.onlineListPanel.Size = new System.Drawing.Size(172, 494);
            this.onlineListPanel.TabIndex = 0;
            this.onlineListPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.onlineListPanel_ControlAdded);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.textBox.Location = new System.Drawing.Point(169, 394);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(673, 96);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "..........";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // ClientUI
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.onlineListPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.operatePanel);
            this.Name = "ClientUI";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientUI_FormClosed);
            this.Load += new System.EventHandler(this.ClientUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel operatePanel;
        private CCWin.SkinControl.SkinButton sendBtn;
        private System.Windows.Forms.FlowLayoutPanel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel onlineListPanel;
        private System.Windows.Forms.TextBox textBox;
    }
}