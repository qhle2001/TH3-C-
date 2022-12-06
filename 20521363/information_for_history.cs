using _20521363.Model;
using _20521363.Properties;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _20521363.Home;
using static _20521363.Main;
using static System.Net.Mime.MediaTypeNames;

namespace _20521363
{
    public partial class information_for_history : Form
    {
        Home formout;
        bool love = true;
        int quantity;
        public information_for_history(Home ucin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            formout = ucin;
            pictureBox1.Image = ucin.music_out.Image;
            label1.Text = ucin.music_out.Name;
            lbst.Text = ucin.music_out.Singer;
            label2.Text = ucin.music_out.Author;
            label5.Text = ucin.music_out.Type;
            lstShow.View = View.Details;
            quantity = 0;
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    quantity++;
                }
            }
            lbquantity.Text = quantity.ToString();
            lstShow.GridLines = true;
            lstShow.Columns.Add("Lần thứ", -2, HorizontalAlignment.Left);
            lstShow.Columns.Add("Thời gian", -2, HorizontalAlignment.Left);
            load_listview();
        }

        private void load_listview()
        {
            int count = 0;
            lstShow.Items.Clear();
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    count++;
                    ListViewItem item = new ListViewItem();
                    item.Text = count.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = history_music_play[i].Date });
                    lstShow.Items.Add(item);
                }
            }
            lstShow.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            lstShow.ForeColor = Color.Black;
        }

        private void btLyrics_Click(object sender, EventArgs e)
        {
            MessageBox.Show(formout.music_out.Lyrics, "Lời bài hát");
        }

        private void btplay_Click(object sender, EventArgs e)
        {
            List<Music> music_play = new List<Music>();
            music_play.Add(formout.music_out);
            play formplay = new play(music_play);
            formplay.ShowDialog();
            quantity = 0;
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    quantity++;
                }
            }
            lbquantity.Text = quantity.ToString();
            load_listview();
        }
        private void btadd_playlist_Click(object sender, EventArgs e)
        {
            add_song_in_playlist newform = new add_song_in_playlist(formout.music_out);
            newform.ShowDialog();
            quantity = 0;
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    quantity++;
                }
            }
            lbquantity.Text = quantity.ToString();
            load_listview();
        }

        private void btdownload_Click(object sender, EventArgs e)
        {
            form_download form = new form_download(formout.music_out.Mp3_4);
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (love)
            {
                pictureBox2.Image = Resources._299063_heart_icon;
                bool flag = true;
                for (int i = 0; i < love_music.Count; i++)
                {
                    if (love_music[i].Name == formout.music_out.Name)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    love_music.Add(formout.music_out);
                }
                love = false;
            }
            else
            {
                pictureBox2.Image = Resources._3643770_favorite_heart_like_likes_love_icon;
                love = true;
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                for (int i = 0; i < history_music_play.Count; i++)
                {
                    if (history_music_play[i].Name == formout.music_out.Name)
                    {
                        history_music_play.RemoveAt(i);
                        i--;
                    }
                }
                formout.load_list_love();
            }
            this.Close();
        }
    }
}
