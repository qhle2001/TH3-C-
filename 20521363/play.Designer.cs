namespace _20521363
{
    partial class play
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name_lyrics = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btdownload = new System.Windows.Forms.Button();
            this.btcontinue = new System.Windows.Forms.Button();
            this.lb_volume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnext = new System.Windows.Forms.Button();
            this.btpause = new System.Windows.Forms.Button();
            this.btplay = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_lyrics = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.lbduration = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbtime = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_name_lyrics);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 794);
            this.panel1.TabIndex = 0;
            // 
            // lb_name_lyrics
            // 
            this.lb_name_lyrics.AutoSize = true;
            this.lb_name_lyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_lyrics.ForeColor = System.Drawing.Color.White;
            this.lb_name_lyrics.Location = new System.Drawing.Point(821, 11);
            this.lb_name_lyrics.Name = "lb_name_lyrics";
            this.lb_name_lyrics.Size = new System.Drawing.Size(55, 20);
            this.lb_name_lyrics.TabIndex = 10;
            this.lb_name_lyrics.Text = "Lyrics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1257, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btdownload);
            this.groupBox1.Controls.Add(this.btcontinue);
            this.groupBox1.Controls.Add(this.lb_volume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.btnext);
            this.groupBox1.Controls.Add(this.btpause);
            this.groupBox1.Controls.Add(this.btplay);
            this.groupBox1.Controls.Add(this.btstop);
            this.groupBox1.Controls.Add(this.btprevious);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(20, 534);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btdownload
            // 
            this.btdownload.BackColor = System.Drawing.Color.Black;
            this.btdownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdownload.ForeColor = System.Drawing.Color.Cyan;
            this.btdownload.Location = new System.Drawing.Point(539, 22);
            this.btdownload.Name = "btdownload";
            this.btdownload.Size = new System.Drawing.Size(123, 41);
            this.btdownload.TabIndex = 10;
            this.btdownload.Text = "Download";
            this.btdownload.UseVisualStyleBackColor = false;
            this.btdownload.Click += new System.EventHandler(this.btdownload_Click);
            // 
            // btcontinue
            // 
            this.btcontinue.BackColor = System.Drawing.Color.Black;
            this.btcontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcontinue.ForeColor = System.Drawing.Color.Cyan;
            this.btcontinue.Location = new System.Drawing.Point(272, 22);
            this.btcontinue.Name = "btcontinue";
            this.btcontinue.Size = new System.Drawing.Size(108, 41);
            this.btcontinue.TabIndex = 9;
            this.btcontinue.Text = "Continue";
            this.btcontinue.UseVisualStyleBackColor = false;
            this.btcontinue.Visible = false;
            this.btcontinue.Click += new System.EventHandler(this.btcontinue_Click);
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.ForeColor = System.Drawing.Color.Cyan;
            this.lb_volume.Location = new System.Drawing.Point(714, 124);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(50, 20);
            this.lb_volume.TabIndex = 8;
            this.lb_volume.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(669, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(674, 74);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 122);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Black;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.ForeColor = System.Drawing.Color.Cyan;
            this.btnext.Location = new System.Drawing.Point(406, 22);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(108, 41);
            this.btnext.TabIndex = 5;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btpause
            // 
            this.btpause.BackColor = System.Drawing.Color.Black;
            this.btpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpause.ForeColor = System.Drawing.Color.Cyan;
            this.btpause.Location = new System.Drawing.Point(272, 22);
            this.btpause.Name = "btpause";
            this.btpause.Size = new System.Drawing.Size(108, 41);
            this.btpause.TabIndex = 4;
            this.btpause.Text = "Pause";
            this.btpause.UseVisualStyleBackColor = false;
            this.btpause.Click += new System.EventHandler(this.btpause_Click);
            // 
            // btplay
            // 
            this.btplay.BackColor = System.Drawing.Color.Black;
            this.btplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btplay.ForeColor = System.Drawing.Color.Cyan;
            this.btplay.Location = new System.Drawing.Point(137, 22);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(108, 41);
            this.btplay.TabIndex = 3;
            this.btplay.Text = "Play";
            this.btplay.UseVisualStyleBackColor = false;
            this.btplay.Visible = false;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // btstop
            // 
            this.btstop.BackColor = System.Drawing.Color.Black;
            this.btstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstop.ForeColor = System.Drawing.Color.Cyan;
            this.btstop.Location = new System.Drawing.Point(137, 22);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(108, 41);
            this.btstop.TabIndex = 2;
            this.btstop.Text = "Stop";
            this.btstop.UseVisualStyleBackColor = false;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // btprevious
            // 
            this.btprevious.BackColor = System.Drawing.Color.Black;
            this.btprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprevious.ForeColor = System.Drawing.Color.Cyan;
            this.btprevious.Location = new System.Drawing.Point(5, 22);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(108, 41);
            this.btprevious.TabIndex = 1;
            this.btprevious.Text = "Previous";
            this.btprevious.UseVisualStyleBackColor = false;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Aqua;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(6, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(657, 154);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.lb_lyrics);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(820, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 723);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lb_lyrics
            // 
            this.lb_lyrics.AutoSize = true;
            this.lb_lyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lyrics.ForeColor = System.Drawing.Color.White;
            this.lb_lyrics.Location = new System.Drawing.Point(3, 0);
            this.lb_lyrics.Name = "lb_lyrics";
            this.lb_lyrics.Size = new System.Drawing.Size(55, 20);
            this.lb_lyrics.TabIndex = 9;
            this.lb_lyrics.Text = "Lyrics";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_name);
            this.panel2.Controls.Add(this.lbduration);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lbtime);
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Location = new System.Drawing.Point(20, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 526);
            this.panel2.TabIndex = 6;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Turquoise;
            this.lb_name.Location = new System.Drawing.Point(0, 465);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(82, 32);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Name";
            // 
            // lbduration
            // 
            this.lbduration.AutoSize = true;
            this.lbduration.ForeColor = System.Drawing.Color.Cyan;
            this.lbduration.Location = new System.Drawing.Point(746, 503);
            this.lbduration.Name = "lbduration";
            this.lbduration.Size = new System.Drawing.Size(38, 16);
            this.lbduration.TabIndex = 3;
            this.lbduration.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(50, 507);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(690, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.ForeColor = System.Drawing.Color.Cyan;
            this.lbtime.Location = new System.Drawing.Point(3, 503);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(38, 16);
            this.lbtime.TabIndex = 1;
            this.lbtime.Text = "00:00";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(594, 405);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 794);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "play";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btpause;
        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_lyrics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lbduration;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbtime;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btcontinue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_name_lyrics;
        private System.Windows.Forms.Button btdownload;
    }
}