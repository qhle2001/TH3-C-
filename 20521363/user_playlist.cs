using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20521363.Model;
using _20521363.Properties;
using static _20521363.Main;

namespace _20521363
{
    public partial class user_playlist : UserControl
    {
        public user_playlist()
        {
            InitializeComponent();
            load_list_view();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            form_add_pl newform = new form_add_pl(this);
            newform.ShowDialog();
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    _playlist.RemoveAt(i);
                    name_song_in_playlist.Clear();
                    i--;
                    label1.Text = "Playlist ";
                }
            }
        }
        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(100,100), ColorDepth = ColorDepth.Depth32Bit };
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
            listView1.Font = new Font("Time New Roman", 16, FontStyle.Bold);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListView lst = sender as ListView;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = lst.SelectedItems[0];
                label1.Text = "Playlist " + item.Text;
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

        public List<Music> play_playlist;

        private void btplay_Click(object sender, EventArgs e)
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

        public class_playlist temp_play;
        public string choose_playlist, name_song_remove;
        public int index_song_remove;
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
                    index_song_remove = listBox1.SelectedIndex;
                    temp_play = new class_playlist(listView1.Items[i].Text, play_playlist[listBox1.SelectedIndex].Name);
                    form_remove_song_in_playlist newform = new form_remove_song_in_playlist(this);
                    newform.ShowDialog();
                }
            }
        }
        internal void upload_listbox()
        {
            listBox1.Items.Clear();
            for (int j = 0; j < name_song_in_playlist.Count; j++)
            {
                if (name_song_in_playlist[j].Name_playlist == temp_play.Name_playlist)
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
