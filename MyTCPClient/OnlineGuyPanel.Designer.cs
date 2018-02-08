namespace MyTCPClient {
    partial class OnlineGuyPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.username = new System.Windows.Forms.Label();
            this.individualWords = new System.Windows.Forms.Label();
            this.headimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(75, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 17);
            this.username.TabIndex = 1;
            this.username.Text = "furious Python";
            // 
            // individualWords
            // 
            this.individualWords.AutoSize = true;
            this.individualWords.Location = new System.Drawing.Point(76, 35);
            this.individualWords.Name = "individualWords";
            this.individualWords.Size = new System.Drawing.Size(71, 12);
            this.individualWords.TabIndex = 2;
            this.individualWords.Text = "...........";
            // 
            // headimg
            // 
            this.headimg.Location = new System.Drawing.Point(3, 3);
            this.headimg.Name = "headimg";
            this.headimg.Size = new System.Drawing.Size(67, 54);
            this.headimg.TabIndex = 0;
            this.headimg.TabStop = false;
            // 
            // OnlineGuyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.individualWords);
            this.Controls.Add(this.username);
            this.Controls.Add(this.headimg);
            this.Name = "OnlineGuyPanel";
            this.Size = new System.Drawing.Size(172, 70);
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headimg;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label individualWords;
    }
}
