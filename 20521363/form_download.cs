using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20521363
{
    public partial class form_download : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public form_download()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string text;

        public form_download(string textin): this()
        {
            text = textin;
            txtSource.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = Path.Combine(fbd.SelectedPath, txtSource.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(txtSource.Text, txtTarget.Text);
            MessageBox.Show("Tải về thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
