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
    public partial class add_song_in_playlist : Form
    {
        public add_song_in_playlist()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Music music_out;
        public add_song_in_playlist(Music music_in): this()
        {
            music_out = music_in;
            load_list_view();
        }

        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(80, 80), ColorDepth = ColorDepth.Depth32Bit };
            imagelist.Images.Add(Resources._640px_Beats_Music_logo_svg);
        }
        internal void load_list_view()
        {
            listView1.Clear();
            LoadImageList();
            listView1.LargeImageList = imagelist;
            for (int i = 0; i < _playlist.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _playlist[i];
                item.ImageIndex = 0;
                listView1.Items.Add(item);
            }
        }
        private void bt_add_playlist_Click(object sender, EventArgs e)
        {
            form_add_playlist_of_user_information newform = new form_add_playlist_of_user_information(this);
            newform.ShowDialog();
        }

        private void bt_add_to_playlist_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    lb_danhsach.Text = "Playlist " + listView1.Items[i].Text;
                    class_playlist clp = new class_playlist(listView1.Items[i].Text, music_out.Name);
                    bool flag = true;
                    for (int j = 0; j < name_song_in_playlist.Count; j++)
                    {
                        if(clp.Name_playlist == name_song_in_playlist[j].Name_playlist && clp.Name_song == name_song_in_playlist[j].Name_song)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        name_song_in_playlist.Add(clp);
                    }
                    for (int j = 0; j < name_song_in_playlist.Count; j++)
                    {
                        if (name_song_in_playlist[j].Name_playlist == listView1.Items[i].Text)
                        {
                            for (int z = 0; z < music.Count; z++)
                            {
                                if (music[z].Name == name_song_in_playlist[j].Name_song)
                                {
                                    listBox1.Items.Add(music[z].Name);
                                }
                            }
                        }
                    }

                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListView lst = sender as ListView;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = lst.SelectedItems[0];
                lb_danhsach.Text = "Playlist " + item.Text;
                for (int j = 0; j < name_song_in_playlist.Count; j++)
                {
                    if (name_song_in_playlist[j].Name_playlist == item.Text)
                    {
                        for (int z = 0; z < music.Count; z++)
                        {
                            if (music[z].Name == name_song_in_playlist[j].Name_song)
                            {
                                listBox1.Items.Add(music[z].Name);
                            }
                        }
                    }
                }

            }
        }

        List<Music> play_playlist;
        private void button1_Click(object sender, EventArgs e)
        {
            play_playlist = new List<Music>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    for (int j = 0; j < name_song_in_playlist.Count; j++)
                    {
                        if (name_song_in_playlist[j].Name_playlist == listView1.Items[i].Text)
                        {
                            for (int z = 0; z < music.Count; z++)
                            {
                                if (music[z].Name == name_song_in_playlist[j].Name_song)
                                {
                                    play_playlist.Add(music[z]);
                                }
                            }
                        }
                    }
                }
            }
            if (play_playlist.Count > 0)
            {
                play newform = new play(play_playlist);
                newform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Playlist rỗng!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        List<Music> play_for_formplay;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            play_playlist = new List<Music>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    for (int j = 0; j < name_song_in_playlist.Count; j++)
                    {
                        if (name_song_in_playlist[j].Name_playlist == listView1.Items[i].Text)
                        {
                            for (int z = 0; z < music.Count; z++)
                            {
                                if (music[z].Name == name_song_in_playlist[j].Name_song)
                                {
                                    play_playlist.Add(music[z]);
                                }
                            }
                        }
                    }
                }
            }
            if (listBox1.SelectedIndex != -1)
            {
                play_for_formplay = new List<Music>();
                play_for_formplay.Add(play_playlist[listBox1.SelectedIndex]);
                play newform = new play(play_for_formplay);
                newform.ShowDialog();
            }
        }
    }
}
