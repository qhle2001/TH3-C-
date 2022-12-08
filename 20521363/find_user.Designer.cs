namespace _20521363
{
    partial class find_user
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiHátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghệSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lờiBàiHátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảToolStripMenuItem,
            this.bàiHátToolStripMenuItem,
            this.nghệSĩToolStripMenuItem,
            this.caSĩToolStripMenuItem,
            this.lờiBàiHátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tấtCảToolStripMenuItem
            // 
            this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
            this.tấtCảToolStripMenuItem.Size = new System.Drawing.Size(108, 39);
            this.tấtCảToolStripMenuItem.Text = "Tất cả";
            this.tấtCảToolStripMenuItem.Click += new System.EventHandler(this.tấtCảToolStripMenuItem_Click);
            // 
            // bàiHátToolStripMenuItem
            // 
            this.bàiHátToolStripMenuItem.Name = "bàiHátToolStripMenuItem";
            this.bàiHátToolStripMenuItem.Size = new System.Drawing.Size(122, 39);
            this.bàiHátToolStripMenuItem.Text = "Bài hát";
            this.bàiHátToolStripMenuItem.Click += new System.EventHandler(this.bàiHátToolStripMenuItem_Click);
            // 
            // nghệSĩToolStripMenuItem
            // 
            this.nghệSĩToolStripMenuItem.Name = "nghệSĩToolStripMenuItem";
            this.nghệSĩToolStripMenuItem.Size = new System.Drawing.Size(123, 39);
            this.nghệSĩToolStripMenuItem.Text = "Nghệ sĩ";
            this.nghệSĩToolStripMenuItem.Click += new System.EventHandler(this.nghệSĩToolStripMenuItem_Click);
            // 
            // caSĩToolStripMenuItem
            // 
            this.caSĩToolStripMenuItem.Name = "caSĩToolStripMenuItem";
            this.caSĩToolStripMenuItem.Size = new System.Drawing.Size(122, 39);
            this.caSĩToolStripMenuItem.Text = "Nhạc sĩ";
            this.caSĩToolStripMenuItem.Click += new System.EventHandler(this.caSĩToolStripMenuItem_Click);
            // 
            // lờiBàiHátToolStripMenuItem
            // 
            this.lờiBàiHátToolStripMenuItem.Name = "lờiBàiHátToolStripMenuItem";
            this.lờiBàiHátToolStripMenuItem.Size = new System.Drawing.Size(171, 39);
            this.lờiBàiHátToolStripMenuItem.Text = "Lời bài hát";
            this.lờiBàiHátToolStripMenuItem.Click += new System.EventHandler(this.lờiBàiHátToolStripMenuItem_Click);
            // 
            // fpn
            // 
            this.fpn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpn.AutoScroll = true;
            this.fpn.Location = new System.Drawing.Point(39, 43);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(1156, 657);
            this.fpn.TabIndex = 1;
            // 
            // find_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "find_user";
            this.Size = new System.Drawing.Size(1195, 700);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiHátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghệSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lờiBàiHátToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel fpn;
    }
}
