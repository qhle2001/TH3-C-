using _20521363.Model;
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
    public partial class form_remove_song_in_playlist : Form
    {
        user_playlist form_out;
        public form_remove_song_in_playlist(user_playlist uc_in)
        {
            InitializeComponent();
            form_out = uc_in;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < name_song_in_playlist.Count; j++)
            {
                if (name_song_in_playlist[j].Name_playlist == form_out.temp_play.Name_playlist && name_song_in_playlist[j].Name_song == form_out.temp_play.Name_song)
                {
                    name_song_in_playlist.RemoveAt(j);
                }
            }
            MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form_out.upload_listbox();
            this.Close();
        }

        List<Music> play_for_formplay;
        private void btplay_Click(object sender, EventArgs e)
        {
            play_for_formplay = new List<Music>();
            play_for_formplay.Add(form_out.play_playlist[form_out.index_song_remove]);
            play newform = new play(play_for_formplay);
            newform.ShowDialog();
            this.Close();
        }
    }
}
