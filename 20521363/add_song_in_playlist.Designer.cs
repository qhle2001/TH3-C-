namespace _20521363
{
    partial class add_song_in_playlist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_danhsach = new System.Windows.Forms.Label();
            this.bt_add_playlist = new System.Windows.Forms.Button();
            this.bt_add_to_playlist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 406);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 406);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(530, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 461);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 461);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.AutoSize = true;
            this.lb_danhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhsach.Location = new System.Drawing.Point(534, 9);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(72, 23);
            this.lb_danhsach.TabIndex = 2;
            this.lb_danhsach.Text = "Playlist";
            // 
            // bt_add_playlist
            // 
            this.bt_add_playlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_playlist.Location = new System.Drawing.Point(0, 409);
            this.bt_add_playlist.Name = "bt_add_playlist";
            this.bt_add_playlist.Size = new System.Drawing.Size(147, 38);
            this.bt_add_playlist.TabIndex = 3;
            this.bt_add_playlist.Text = "Tạo Playlist";
            this.bt_add_playlist.UseVisualStyleBackColor = true;
            this.bt_add_playlist.Click += new System.EventHandler(this.bt_add_playlist_Click);
            // 
            // bt_add_to_playlist
            // 
            this.bt_add_to_playlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_to_playlist.Location = new System.Drawing.Point(167, 409);
            this.bt_add_to_playlist.Name = "bt_add_to_playlist";
            this.bt_add_to_playlist.Size = new System.Drawing.Size(193, 38);
            this.bt_add_to_playlist.TabIndex = 4;
            this.bt_add_to_playlist.Text = "Thêm vào Playlist";
            this.bt_add_to_playlist.UseVisualStyleBackColor = true;
            this.bt_add_to_playlist.Click += new System.EventHandler(this.bt_add_to_playlist_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Phát nhạc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_song_in_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_add_to_playlist);
            this.Controls.Add(this.bt_add_playlist);
            this.Controls.Add(this.lb_danhsach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_song_in_playlist";
            this.Text = "Playlist";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_danhsach;
        private System.Windows.Forms.Button bt_add_playlist;
        private System.Windows.Forms.Button bt_add_to_playlist;
        private System.Windows.Forms.Button button1;
    }
}