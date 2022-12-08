using _20521363.Model;
using _20521363.Properties;
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
    public partial class Information : Form
    {
        bool love = true;
        Home formout;
        Music musicout;
        string text;
        bool flag_check = false;
        public Information()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Information(Music musicin): this()
        {
            musicout = musicin;
            pictureBox1.Image = musicout.Image;
            label1.Text = musicout.Name;
            lbst.Text = musicout.Singer;
            label2.Text = musicout.Author;
            label5.Text = musicout.Type;
        }
        public Information(Home ucin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            flag_check = true;
            formout = ucin;
            text = ucin.text_out;
            pictureBox1.Image = ucin.music_out.Image;
            label1.Text = ucin.music_out.Name;
            lbst.Text = ucin.music_out.Singer;
            label2.Text = ucin.music_out.Author;
            label5.Text = ucin.music_out.Type;
            if (text == "Yêu thích")
            {
                btdelete.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                btdelete.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes) 
            {
                formout.load_list_love();
                this.Close(); 
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btplay_Click(object sender, EventArgs e)
        {
            List<Music> music_play = new List<Music>();
            if (flag_check)
            {
                music_play.Add(formout.music_out);
            }
            else
            {
                music_play.Add(musicout);
            }
            play formplay = new play(music_play);
            formplay.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (love)
            {
                pictureBox2.Image = Resources._299063_heart_icon;
                bool flag = true;
                for (int i = 0; i < love_music.Count; i++)
                {
                    if (flag_check)
                    {
                        if (love_music[i].Name == formout.music_out.Name)
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        if (love_music[i].Name == musicout.Name)
                        {
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    if (flag_check)
                    {
                        love_music.Add(formout.music_out);
                    }
                    else
                    {
                        love_music.Add(musicout);
                    }
                }
                love = false;
            }
            else
            {
                pictureBox2.Image = Resources._3643770_favorite_heart_like_likes_love_icon;
                love = true;
            }
        }

        private void btLyrics_Click(object sender, EventArgs e)
        {
            if (flag_check)
            {
                MessageBox.Show(formout.music_out.Lyrics, "Lời bài hát");
            }
            else
            {
                MessageBox.Show(musicout.Lyrics, "Lời bài hát");
            }
        }

        private void btdownload_Click(object sender, EventArgs e)
        {
            if (flag_check)
            {
                form_download form = new form_download(formout.music_out.Mp3_4);
                form.ShowDialog();
            }
            else
            {
                form_download form = new form_download(musicout.Mp3_4);
                form.ShowDialog();
            }
        }

        private void btadd_playlist_Click(object sender, EventArgs e)
        {
            if (flag_check)
            {
                add_song_in_playlist newform = new add_song_in_playlist(formout.music_out);
                newform.ShowDialog();
            }
            else
            {
                add_song_in_playlist newform = new add_song_in_playlist(musicout);
                newform.ShowDialog();
            }
        }
    }
}
