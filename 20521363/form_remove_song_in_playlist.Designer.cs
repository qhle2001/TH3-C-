namespace _20521363
{
    partial class form_remove_song_in_playlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.btremove = new System.Windows.Forms.Button();
            this.btplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn muốn xóa hay muốn phát?";
            // 
            // btremove
            // 
            this.btremove.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btremove.Location = new System.Drawing.Point(12, 64);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(222, 41);
            this.btremove.TabIndex = 1;
            this.btremove.Text = "Xóa khỏi Playlist";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // btplay
            // 
            this.btplay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btplay.Location = new System.Drawing.Point(253, 64);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(217, 41);
            this.btplay.TabIndex = 2;
            this.btplay.Text = "Phát nhạc";
            this.btplay.UseVisualStyleBackColor = true;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // form_remove_song_in_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 117);
            this.Controls.Add(this.btplay);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_remove_song_in_playlist";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btremove;
        private System.Windows.Forms.Button btplay;
    }
}