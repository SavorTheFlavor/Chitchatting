namespace MyTCPClient {
    partial class MsgPanelOthers {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contentPanel1 = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.TextBox();
            this.headimg = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.contentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Location = new System.Drawing.Point(79, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 16);
            this.panel2.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 12);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Lazy Java";
            // 
            // contentPanel1
            // 
            this.contentPanel1.Controls.Add(this.content);
            this.contentPanel1.Location = new System.Drawing.Point(79, 40);
            this.contentPanel1.Name = "contentPanel1";
            this.contentPanel1.Size = new System.Drawing.Size(235, 66);
            this.contentPanel1.TabIndex = 9;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.LightGray;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Dock = System.Windows.Forms.DockStyle.Left;
            this.content.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(209, 66);
            this.content.TabIndex = 5;
            this.content.Text = "..............................................................";
            // 
            // headimg
            // 
            this.headimg.Image = global::MyTCPClient.Properties.Resources.hush;
            this.headimg.Location = new System.Drawing.Point(3, 18);
            this.headimg.Name = "headimg";
            this.headimg.Size = new System.Drawing.Size(67, 54);
            this.headimg.TabIndex = 8;
            this.headimg.TabStop = false;
            // 
            // MsgPanelOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contentPanel1);
            this.Controls.Add(this.headimg);
            this.Name = "MsgPanelOthers";
            this.Size = new System.Drawing.Size(673, 117);
            this.Load += new System.EventHandler(this.MsgPanelOthers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contentPanel1.ResumeLayout(false);
            this.contentPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel contentPanel1;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.PictureBox headimg;
    }
}
