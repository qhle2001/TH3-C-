using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521363.Model
{
    public class class_history_music
    {
        public string Name { set; get; }
        public string Date { set; get; }
        public class_history_music(string name, string date)
        {
            Name = name;
            Date = date;
        }
    }
}
