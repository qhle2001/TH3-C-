using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521363.Model
{
    public class Music
    {
        public string Name { set; get; }
        public Image Image { set; get; }
        public string Type { set; get; }
        public string Author { set; get; }
        public string Singer { set; get; }
        public string Mp3_4 { set; get; }
        public string Lyrics { set; get; }
        public Music (string name, Image image, string type, string author, string singer, string mp3_4, string lyrics)
        {
            Name = name;
            Image = image;
            Type = type;
            Author = author;
            Singer = singer;
            Mp3_4 = mp3_4;
            Lyrics = lyrics;
        }
    }
}
