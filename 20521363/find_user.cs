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
            Panel pn_type = new Panel();
            Label lbl_type = new Label();
            lbl_type.Text = "Bài hát -------------------------------------------------------------------------------------------------------------------------------------------------------";
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbl_type.Location = new Point(1, 10);
            pn_type.Size = new Size(1200, 50);
            pn_type.Controls.Add(lbl_type);
            fpn.Controls.Add(pn_type);
            load_song();
            load_author();
            load_singer();
            load_lyrics();
        }
        List<Music> music_find;
        bool flag_author, flag_singer;
        bool check_author, check_singer;
        private void find_result()
        {
            music_find = new List<Music>();
            for (int i = 0; i < musicout.Count; i++)
            {
                #region check character
                flag_author = false; flag_singer = false;
                for (int idx_author = 0; idx_author < musicout[i].Author.Length; idx_author++)
                {
                    if (musicout[i].Author[idx_author] == ',')
                    {
                        flag_author = true; break;
                    }
                        
                }
                for (int idx_author = 0; idx_author < musicout[i].Singer.Length; idx_author++)
                {
                    if (musicout[i].Singer[idx_author] == ',')
                    {
                        flag_singer = true; break;
                    }
                }
                #endregion
                #region check textout in musicout
                check_author = false; check_singer = false;
                if (flag_author)
                {
                    string[] temp = musicout[i].Author.Split(',');
                    for (int j = 0; j < temp.Length; j++)
                    {
                        temp[j] = temp[j].Trim().ToLower();
                        if (textout == temp[j])
                        {
                            check_author = true; break;
                        }
                    }
                }
                else
                {
                    if (textout == musicout[i].Author.Trim().ToLower())
                    {
                        check_author = true;
                    }
                }
                if (flag_singer)
                {
                    string[] temp = musicout[i].Singer.Split(',');
                    for (int j = 0; j < temp.Length; j++)
                    {
                        temp[j] = temp[j].Trim().ToLower();
                        if (textout == temp[j])
                        {
                            check_singer = true; break;
                        }
                    }
                }
                else
                {
                    if (textout == musicout[i].Singer.Trim().ToLower())
                    {
                        check_singer = true;
                    }
                }
                #endregion
                if (textout == musicout[i].Name.Trim().ToLower() || check_author == true || check_singer == true)
                {
                    music_find.Add(musicout[i]);
                }
            }
        }
        private void load_song()
        {
            find_result();
            for (int i = 0; i < music_find.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = music_find[i].Name;
                lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                lbl.AutoSize = true;
                lbl.Location = new Point(90, 20);

                Label lbl2 = new Label();
                lbl2.Text = music_find[i].Singer;
                lbl2.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                lbl2.AutoSize = true;
                lbl2.Location = new Point(90, 45);

                PictureBox ptb = new PictureBox();
                ptb.Tag = music_find[i].Name;
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb.Size = new Size(70, 70);
                ptb.Image = music_find[i].Image;
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

        private void load_author()
        {
            Panel pn_type = new Panel();
            Label lbl_type = new Label();
            lbl_type.Text = "Sáng tác -------------------------------------------------------------------------------------------------------------------------------------------------------";
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbl_type.Location = new Point(1, 10);
            pn_type.Size = new Size(1200, 50);
            pn_type.Controls.Add(lbl_type);
            fpn.Controls.Add(pn_type);
            if (textout == music_find[0].Name.Trim().ToLower())
            {
                List<string> author = new List<string>();
                for (int i = 0; i < music_find.Count; i++)
                {
                    bool flag_check_author = false;
                    for (int idx_author = 0; idx_author < music_find[i].Author.Length; idx_author++)
                    {
                        if (music_find[i].Author[idx_author] == ',')
                        {
                            flag_check_author = true; break;
                        }
                    }
                    if (flag_check_author)
                    {
                        string[] temp = music_find[i].Author.Split(',');
                        for (int j = 0; j < temp.Length; j++)
                        {
                            temp[j] = temp[j].Trim();
                            author.Add(temp[j]);
                        }
                    }
                    else
                    {
                        author.Add(music_find[i].Author);
                    }
                }
                for (int i = 0; i < author.Count; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = author[i];
                    lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                    lbl.AutoSize = true;
                    lbl.Location = new Point(90, 35);

                    PictureBox ptb = new PictureBox();
                    ptb.Tag = author[i];
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
            else
            {
                List<string> author = new List<string>();
                for (int i = 0; i < music_find.Count; i++)
                {
                    bool flag_check_author = false;
                    for (int idx_author = 0; idx_author < music_find[i].Author.Length; idx_author++)
                    {
                        if (music_find[i].Author[idx_author] == ',')
                        {
                            flag_check_author = true; break;
                        }
                    }
                    if (flag_check_author)
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
                    else
                    {
                        if (textout == music_find[i].Author.Trim().ToLower())
                        {
                            author.Add(music_find[i].Author);
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
                    for (int i = 0; i < author.Count; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = author[i];
                        lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                        lbl.AutoSize = true;
                        lbl.Location = new Point(90, 35);

                        PictureBox ptb = new PictureBox();
                        ptb.Tag = author[i];
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
                else
                {
                    List<string> author_ = new List<string>();
                    for (int i = 0; i < music_find.Count; i++)
                    {
                        bool flag_check_author = false;
                        for (int idx_author = 0; idx_author < music_find[i].Author.Length; idx_author++)
                        {
                            if (music_find[i].Author[idx_author] == ',')
                            {
                                flag_check_author = true; break;
                            }
                        }
                        if (flag_check_author)
                        {
                            string[] temp = music_find[i].Author.Split(',');
                            for (int j = 0; j < temp.Length; j++)
                            {
                                temp[j] = temp[j].Trim();
                                author_.Add(temp[j]);
                            }
                        }
                        else
                        {
                            author_.Add(music_find[i].Author);
                        }
                    }
                    for (int i = 0; i < author_.Count; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = author_[i];
                        lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                        lbl.AutoSize = true;
                        lbl.Location = new Point(90, 35);

                        PictureBox ptb = new PictureBox();
                        ptb.Tag = author_[i];
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
            }
        }

        private void load_singer()
        {
            Panel pn_type = new Panel();
            Label lbl_type = new Label();
            lbl_type.Text = "Thực hiện -------------------------------------------------------------------------------------------------------------------------------------------------------";
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbl_type.Location = new Point(1, 10);
            pn_type.Size = new Size(1200, 50);
            pn_type.Controls.Add(lbl_type);
            fpn.Controls.Add(pn_type);
            if (textout == music_find[0].Name.Trim().ToLower())
            {
                List<string> singer = new List<string>();
                for (int i = 0; i < music_find.Count; i++)
                {
                    bool flag_check_singer = false;
                    for (int idx_singer = 0; idx_singer < music_find[i].Singer.Length; idx_singer++)
                    {
                        if (music_find[i].Singer[idx_singer] == ',')
                        {
                            flag_check_singer = true; break;
                        }
                    }
                    if (flag_check_singer)
                    {
                        string[] temp = music_find[i].Singer.Split(',');
                        for (int j = 0; j < temp.Length; j++)
                        {
                            temp[j] = temp[j].Trim();
                            singer.Add(temp[j]);
                        }
                    }
                    else
                    {
                        singer.Add(music_find[i].Singer);
                    }
                }
                for (int i = 0; i < singer.Count; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = singer[i];
                    lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                    lbl.AutoSize = true;
                    lbl.Location = new Point(90, 35);

                    PictureBox ptb = new PictureBox();
                    ptb.Tag = singer[i];
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.Size = new Size(70, 70);
                    ptb.Image = Resources.singer;
                    ptb.Location = new Point(10, 10);

                    Panel pn = new Panel();
                    pn.Size = new Size(400, 90);
                    pn.Controls.Add(ptb);
                    pn.Controls.Add(lbl);
                    fpn.Controls.Add(pn);
                }
            }
            else
            {
                List<string> singer = new List<string>();
                for (int i = 0; i < music_find.Count; i++)
                {
                    bool flag_check_singer = false;
                    for (int idx_singer = 0; idx_singer < music_find[i].Singer.Length; idx_singer++)
                    {
                        if (music_find[i].Singer[idx_singer] == ',')
                        {
                            flag_check_singer = true; break;
                        }
                    }
                    if (flag_check_singer)
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
                    else
                    {
                        if (textout == music_find[i].Singer.Trim().ToLower())
                        {
                            singer.Add(music_find[i].Singer);
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
                    for (int i = 0; i < singer.Count; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = singer[i];
                        lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                        lbl.AutoSize = true;
                        lbl.Location = new Point(90, 35);

                        PictureBox ptb = new PictureBox();
                        ptb.Tag = singer[i];
                        ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                        ptb.Size = new Size(70, 70);
                        ptb.Image = Resources.singer;
                        ptb.Location = new Point(10, 10);

                        Panel pn = new Panel();
                        pn.Size = new Size(400, 90);
                        pn.Controls.Add(ptb);
                        pn.Controls.Add(lbl);
                        fpn.Controls.Add(pn);
                    }
                }
                else
                {
                    List<string> singer_ = new List<string>();
                    for (int i = 0; i < music_find.Count; i++)
                    {
                        bool flag_check_singer = false;
                        for (int idx_singer = 0; idx_singer < music_find[i].Singer.Length; idx_singer++)
                        {
                            if (music_find[i].Singer[idx_singer] == ',')
                            {
                                flag_check_singer = true; break;
                            }
                        }
                        if (flag_check_singer)
                        {
                            string[] temp = music_find[i].Singer.Split(',');
                            for (int j = 0; j < temp.Length; j++)
                            {
                                temp[j] = temp[j].Trim();
                                singer_.Add(temp[j]);
                            }
                        }
                        else
                        {
                            singer_.Add(music_find[i].Singer);
                        }
                    }
                    for (int i = 0; i < singer_.Count; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = singer_[i];
                        lbl.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                        lbl.AutoSize = true;
                        lbl.Location = new Point(90, 35);

                        PictureBox ptb = new PictureBox();
                        ptb.Tag = singer_[i];
                        ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                        ptb.Size = new Size(70, 70);
                        ptb.Image = Resources.singer;
                        ptb.Location = new Point(10, 10);

                        Panel pn = new Panel();
                        pn.Size = new Size(400, 90);
                        pn.Controls.Add(ptb);
                        pn.Controls.Add(lbl);
                        fpn.Controls.Add(pn);
                    }
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
            load_song();
        }

        private void bàiHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tấtCảToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            bàiHátToolStripMenuItem.BackColor = Color.FromArgb(0, 178, 238);
            nghệSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            caSĩToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            lờiBàiHátToolStripMenuItem.BackColor = Color.FromArgb(224, 238, 224);
            fpn.Controls.Clear();
            load_song();
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
