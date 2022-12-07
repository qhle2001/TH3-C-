using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using _20521363.Model;
using _20521363.Properties;

namespace _20521363
{
    public partial class find_user : UserControl
    {
        public find_user()
        {
            InitializeComponent();
        }

        List<Music> musicout;
        string textout;
        public find_user(List<Music> musicin, string text): this()
        {
            musicout = musicin;
            textout = text.Trim().ToLower();
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            find_result();
            load_singer();
            load_author();
            load_lyrics();
        }
        List<Music> music_find;
        bool check_singer_global = false;
        private void find_result()
        {
            bool check_author, check_singer;
            music_find = new List<Music>();
            for (int i = 0; i < musicout.Count; i++)
            {
                check_author = false; check_singer = false;
                string[] temp_author = musicout[i].Author.Split(',');
                for (int j = 0; j < temp_author.Length; j++)
                {
                    temp_author[j] = temp_author[j].Trim().ToLower();
                    if (textout == temp_author[j])
                    {
                        check_author = true; break;
                    }
                }
                string[] temp_singer = musicout[i].Singer.Split(',');
                for (int j = 0; j < temp_singer.Length; j++)
                {
                    temp_singer[j] = temp_singer[j].Trim().ToLower();
                    if (textout == temp_singer[j])
                    {
                        check_singer = true;
                        check_singer_global = true;
                        break;
                    }
                }
                if (textout == musicout[i].Name.Trim().ToLower() || check_author == true || check_singer == true)
                {
                    music_find.Add(musicout[i]);
                }
            }
        }
        #region load_fpn
        private void load_category(string text)
        {
            Panel pn_type = new Panel();
            Label lbl_type = new Label();
            lbl_type.Text = text + " -------------------------------------------------------------------------------------------------------------------------------------------------------";
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbl_type.Location = new Point(1, 10);
            pn_type.Size = new Size(1200, 50);
            pn_type.Controls.Add(lbl_type);
            fpn.Controls.Add(pn_type);
        }

        private void load_fpn(List<string> type)
        {
            for (int i = 0; i < type.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = type[i];
                lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                lbl.AutoSize = true;
                lbl.Location = new Point(90, 35);

                PictureBox ptb = new PictureBox();
                ptb.Tag = type[i];
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb.Size = new Size(70, 70);
                ptb.Image = Resources.compose;
                ptb.Location = new Point(10, 10);

                Panel pn = new Panel();
                pn.Size = new Size(400, 90);
                pn.Controls.Add(ptb);
                pn.Controls.Add(lbl);
                fpn.Controls.Add(pn);
            }
        }
        #endregion
        private void load_song(List<Music> songs)
        {
            load_category("Bài hát");
            for (int i = 0; i < songs.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = songs[i].Name;
                lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                lbl.AutoSize = true;
                lbl.Location = new Point(90, 20);

                Label lbl2 = new Label();
                lbl2.Text = songs[i].Singer;
                lbl2.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                lbl2.AutoSize = true;
                lbl2.Location = new Point(90, 45);

                PictureBox ptb = new PictureBox();
                ptb.Tag = songs[i].Name;
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb.Size = new Size(70, 70);
                ptb.Image = songs[i].Image;
                ptb.Location = new Point(10, 10);

                Panel pn = new Panel();
                pn.Size = new Size(400, 90);
                pn.Controls.Add(ptb);
                pn.Controls.Add(lbl);
                pn.Controls.Add(lbl2);
                fpn.Controls.Add(pn);
                //ptb.Click += new EventHandler(ptb_click);

            }
        }
        #region loadauthorsinger
        private void load_fpn_author(List<string> author)
        {
            for (int i = 0; i < music_find.Count; i++)
            {
                string[] temp = music_find[i].Author.Split(',');
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = temp[j].Trim();
                    author.Add(temp[j]);
                }
            }
        }
        private void load_fpn_singer(List<string> singer)
        {
            for (int i = 0; i < music_find.Count; i++)
            {
                string[] temp = music_find[i].Singer.Split(',');
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = temp[j].Trim();
                    singer.Add(temp[j]);
                }
            }
        }
        #endregion
        private void load_author()
        {
            load_category("Nhạc sĩ");
            if (textout == music_find[0].Name.Trim().ToLower())
            {
                List<string> author = new List<string>();
                load_song(music_find);
                load_category("Nhạc sĩ");
                load_fpn_author(author);
                load_fpn(author);
            }
            else
            {
                List<string> author = new List<string>();
                List<string> song = new List<string>();
                if (check_singer_global)
                {
                    for (int i = 0; i < music_find.Count; i++)
                    {
                        bool check_singer = false;
                        string[] temp_singer = music_find[i].Singer.Split(',');
                        for (int j = 0; j < temp_singer.Length; j++)
                        {
                            string temp = temp_singer[j].Trim().ToLower();
                            if (textout == temp)
                            {
                                check_singer = true;
                                break;
                            }
                        }
                        if (check_singer)
                        {
                            string[] temp_author = music_find[i].Author.Split(',');
                            for (int j = 0; j < temp_author.Length; j++)
                            {
                                author.Add(temp_author[j].Trim());
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < music_find.Count; i++)
                    {
                        string[] temp = music_find[i].Author.Split(',');
                        for (int j = 0; j < temp.Length; j++)
                        {
                            string temp_ = temp[j].Trim().ToLower();
                            if (textout == temp_)
                            {
                                author.Add(temp[j].Trim());
                            }
                        }
                    }
                }
                
                for (int i = 0; i < author.Count - 1; i++)
                {
                    if (author[i] == author[i + 1])
                    {
                        author.RemoveAt(i);
                        i--;
                    }
                }
                if (author.Count > 0)
                {
                    load_fpn(author);
                }
                else
                {
                    List<string> author_ = new List<string>();
                    load_fpn_author(author_);
                    load_fpn(author_);
                }
            }
        }

        private void load_singer()
        {
            load_category("Thực hiện");
            if (textout == music_find[0].Name.Trim().ToLower())
            {
                List<string> singer = new List<string>();
                load_fpn_singer(singer);
                load_fpn(singer);
            }
            else
            {
                List<string> singer = new List<string>();
                for (int i = 0; i < music_find.Count; i++)
                {
                    string[] temp = music_find[i].Singer.Split(',');
                    for (int j = 0; j < temp.Length; j++)
                    {
                        string temp_ = temp[j].Trim().ToLower();
                        if (textout == temp_)
                        {
                            singer.Add(temp[j].Trim());
                        }
                    }
                }
                for (int i = 0; i < singer.Count - 1; i++)
                {
                    if (singer[i] == singer[i + 1])
                    {
                        singer.RemoveAt(i);
                        i--;
                    }
                }
                if (singer.Count > 0)
                {
                    load_fpn(singer);
                }
                else
                {
                    List<string> singer_ = new List<string>();
                    load_fpn_singer(singer_);
                    load_fpn(singer_);
                }
            }
        }

        private void load_lyrics()
        {
            Panel pn_type = new Panel();
            Label lbl_type = new Label();
            lbl_type.Text = "Lời bài hát -------------------------------------------------------------------------------------------------------------------------------------------------------";
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbl_type.Location = new Point(1, 10);
            pn_type.Size = new Size(1200, 50);
            pn_type.Controls.Add(lbl_type);
            fpn.Controls.Add(pn_type);
            for (int i = 0; i < music_find.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = "Lời bài hát: " + music_find[i].Name;
                lbl.Font = new Font("Times New Roman", 18, FontStyle.Bold);
                lbl.AutoSize = true;

                Label lbl2 = new Label();
                lbl2.Text = music_find[i].Lyrics;
                lbl2.Font = new Font("Times New Roman", 16, FontStyle.Regular);
                lbl2.AutoSize = true;
                lbl2.Location = new Point(0, 35);
                Panel pn = new Panel();
                pn.Controls.Add(lbl2);
                pn.Controls.Add(lbl);
                pn.AutoSize = true;

                fpn.Controls.Add(pn);
                //ptb.Click += new EventHandler(ptb_click);

            }
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            fpn.Controls.Clear();
            Panel pn_type = new Panel();
            Label lbl_type = new Label();
            lbl_type.Text = "Bài hát -------------------------------------------------------------------------------------------------------------------------------------------------------";
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbl_type.Location = new Point(1, 10);
            pn_type.Size = new Size(1200, 50);
            pn_type.Controls.Add(lbl_type);
            fpn.Controls.Add(pn_type);
        }

        private void bàiHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            fpn.Controls.Clear();
        }

        private void nghệSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
        }

        private void caSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
        }

        private void lờiBàiHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
        }
    }
}
