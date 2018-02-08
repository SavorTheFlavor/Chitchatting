namespace MyTCPClient {
    partial class MsgPanelSelf {
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.nameLabel = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.contentPanel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headimg = new System.Windows.Forms.PictureBox();
            this.contentPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameLabel.Location = new System.Drawing.Point(141, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 12);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Lazy Java";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.SpringGreen;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Dock = System.Windows.Forms.DockStyle.Right;
            this.content.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content.Location = new System.Drawing.Point(3, 0);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(232, 66);
            this.content.TabIndex = 5;
            this.content.Text = "..............................................................";
            // 
            // contentPanel1
            // 
            this.contentPanel1.Controls.Add(this.content);
            this.contentPanel1.Location = new System.Drawing.Point(352, 27);
            this.contentPanel1.Name = "contentPanel1";
            this.contentPanel1.Size = new System.Drawing.Size(235, 66);
            this.contentPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Location = new System.Drawing.Point(387, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 16);
            this.panel2.TabIndex = 7;
            // 
            // headimg
            // 
            this.headimg.Image = global::MyTCPClient.Properties.Resources.hush;
            this.headimg.Location = new System.Drawing.Point(593, 12);
            this.headimg.Name = "headimg";
            this.headimg.Size = new System.Drawing.Size(67, 54);
            this.headimg.TabIndex = 3;
            this.headimg.TabStop = false;
            // 
            // MsgPanelSelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contentPanel1);
            this.Controls.Add(this.headimg);
            this.Name = "MsgPanelSelf";
            this.Size = new System.Drawing.Size(673, 115);
            this.contentPanel1.ResumeLayout(false);
            this.contentPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox headimg;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Panel contentPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}
