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
using _20521363.Model;
namespace _20521363
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        List<Music> musicout;
        List<Music> play_music;
        public string text_out;
        public Home(List<Music> musicin, string text): this()
        {
            musicout = musicin;
            text_out = text;
            choose_list_music();
        }
        private void show_list_music_homeand_love()
        {
            play_music = new List<Music>();
            if (text_out != "Lịch sử")
            {
                for (int i = 0; i < musicout.Count; i++)
                {
                    if (text_out != "Yêu thích")
                    {
                        if (i == 0 || i == 10 || i == 20 || i == 30)
                        {
                            Panel pn_type = new Panel();
                            Label lbl_type = new Label();
                            lbl_type.Text = musicout[i].Type + "-------------------------------------------------------------------------------------------------------------------------------------------------------";
                            lbl_type.AutoSize = true;
                            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
                            lbl_type.Location = new Point(1, 10);
                            pn_type.Size = new Size(1200, 50);
                            pn_type.Controls.Add(lbl_type);
                            fpn.Controls.Add(pn_type);
                        }
                    }
                    Label lbl = new Label();
                    lbl.Text = musicout[i].Name;
                    lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                    lbl.AutoSize = true;
                    lbl.Location = new Point(90, 20);

                    Label lbl2 = new Label();
                    lbl2.Text = musicout[i].Singer;
                    lbl2.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(90, 45);

                    PictureBox ptb = new PictureBox();
                    ptb.Tag = musicout[i].Name;
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.Size = new Size(70, 70);
                    ptb.Image = musicout[i].Image;
                    ptb.Location = new Point(10, 10);

                    Panel pn = new Panel();
                    pn.Size = new Size(400, 90);
                    pn.Controls.Add(ptb);
                    pn.Controls.Add(lbl);
                    pn.Controls.Add(lbl2);
                    fpn.Controls.Add(pn);
                    play_music.Add(musicout[i]);
                    ptb.Click += new EventHandler(ptb_click);
                }
            }
            if (text_out == "Lịch sử")
            {
                for (int i = 0; i < history_music_play.Count; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = history_music_play[i].Name;
                    lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                    lbl.AutoSize = true;
                    lbl.Location = new Point(90, 20);

                    Label lbl2 = new Label();
                    lbl2.Text = history_music_play[i].Date;
                    lbl2.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(90, 45);

                    Panel pn = new Panel();
                    pn.Size = new Size(400, 90);
                    pn.Controls.Add(lbl);
                    pn.Controls.Add(lbl2);
                    fpn.Controls.Add(pn);
                }
            }
        }

        private void show_list_music_category()
        {
            play_music = new List<Music>();
            string a = text_out.Trim().ToLower();
            string[] split_a = a.Split(' ');
            for (int i = 0; i < musicout.Count; i++)
            {
                int count = 0;
                string temp = musicout[i].Type.ToLower();
                string[] split_temp = temp.Split(' ');
                for (int j = 0; j < split_a.Length; j++)
                {
                    for (int z = 0; z < split_temp.Length; z++)
                    {
                        if (split_a[j] == split_temp[z])
                        {
                            count++;
                        }
                    }
                }
              
                if (count == split_a.Length)
                {
                    Label lbl = new Label();
                    lbl.Text = musicout[i].Name;
                    lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                    lbl.AutoSize = true;
                    lbl.Location = new Point(90, 20);

                    Label lbl2 = new Label();
                    lbl2.Text = musicout[i].Singer;
                    lbl2.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(90, 45);

                    PictureBox ptb = new PictureBox();
                    ptb.Tag = musicout[i].Name;
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.Size = new Size(70, 70);
                    ptb.Image = musicout[i].Image;
                    ptb.Location = new Point(10, 10);

                    Panel pn = new Panel();
                    pn.Size = new Size(400, 90);
                    pn.Controls.Add(ptb);
                    pn.Controls.Add(lbl);
                    pn.Controls.Add(lbl2);
                    fpn.Controls.Add(pn);
                    play_music.Add(musicout[i]);
                    ptb.Click += new EventHandler(ptb_click);
                }
            }
        }

        private void choose_list_music()
        {
            if (text_out != "Trang chủ" && text_out != "Yêu thích" && text_out != "Lịch sử")
            {
                show_list_music_category();
            }
            else
            {
                show_list_music_homeand_love();
            }
        }
        public Music music_out;
        private void ptb_click(object sender, EventArgs e)
        {
            for (int i = 0; i < musicout.Count; i++)
            {
                if (musicout[i].Name == ((PictureBox)sender).Tag)
                {
                    music_out = musicout[i];
                    Information newform = new Information(this);
                    newform.ShowDialog();
                }
            }
        }
        internal void load_list_love()
        {
            for ( int i = 0; i < musicout.Count; i++)
            {
                if (musicout[i].Name == music_out.Name)
                {
                    musicout.Remove(musicout[i]);
                }
            }
            fpn.Controls.Clear();
            show_list_music_homeand_love();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (play_music.Count > 0)
            {
                play newform = new play(play_music);
                newform.ShowDialog();
            }
        }
    }
}
