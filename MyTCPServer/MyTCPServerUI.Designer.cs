namespace MyServer {
    partial class MyTCPServerUI {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.consolePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // consolePanel
            // 
            this.consolePanel.AutoScroll = true;
            this.consolePanel.Location = new System.Drawing.Point(1, 35);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Size = new System.Drawing.Size(624, 457);
            this.consolePanel.TabIndex = 0;
            this.consolePanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.consolePanel_ControlAdded);
            // 
            // MyTCPServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(632, 499);
            this.Controls.Add(this.consolePanel);
            this.EffectBack = System.Drawing.Color.DimGray;
            this.Name = "MyTCPServerUI";
            this.ShadowColor = System.Drawing.Color.Gray;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyTCPServerUI_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel consolePanel;

    }
}

