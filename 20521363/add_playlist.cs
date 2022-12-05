using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _20521363.Main;

namespace _20521363
{
    public partial class form_add_pl : Form
    {
        user_playlist form_out;
        public form_add_pl(user_playlist uc_in)
        {
            InitializeComponent();
            this.form_out = uc_in;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            _playlist.Add(textBox1.Text);
            form_out.load_list_view();
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    _playlist.Add(textBox1.Text);
                    form_out.load_list_view();
                    this.Close();
                }
            }
        }
    }
}
