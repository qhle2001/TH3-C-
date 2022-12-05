using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _20521363.Model
{
    public class class_playlist
    {
        public string Name_playlist { set; get; }
        public string Name_song { set; get; }
        public class_playlist(string name_playlist, string name_song)
        {
            Name_playlist = name_playlist;
            Name_song = name_song;
        }
    }
}
