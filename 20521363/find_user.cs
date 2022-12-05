using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _20521363
{
    public partial class find_user : UserControl
    {
        public find_user()
        {
            InitializeComponent();
        }
        public find_user(string text): this()
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            user_of_find_detail uc = new user_of_find_detail(tấtCảToolStripMenuItem.Text);
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pncontainer_result.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            user_of_find_detail uc = new user_of_find_detail(tấtCảToolStripMenuItem.Text);
            addUserControl(uc);
        }

        private void bàiHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            user_of_find_detail uc = new user_of_find_detail(bàiHátToolStripMenuItem.Text);
            addUserControl(uc);
        }

        private void nghệSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            user_of_find_detail uc = new user_of_find_detail(nghệSĩToolStripMenuItem.Text);
            addUserControl(uc);
        }

        private void caSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            user_of_find_detail uc = new user_of_find_detail(caSĩToolStripMenuItem.Text);
            addUserControl(uc);
        }

        private void lờiBàiHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            user_of_find_detail uc = new user_of_find_detail(lờiBàiHátToolStripMenuItem.Text);
            addUserControl(uc);
        }
    }
}
