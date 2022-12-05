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
    public partial class user_of_find_detail : UserControl
    {
        public user_of_find_detail()
        {
            InitializeComponent();
        }
        string text_out;
        public user_of_find_detail(string text_in): this()
        {
            text_out = text_in;
        }
    }
}
