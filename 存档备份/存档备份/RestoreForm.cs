using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 存档备份
{
    public partial class RestoreForm : Form
    {
        string GameNameStr;
        public RestoreForm()
        {
            InitializeComponent();
        }
        public RestoreForm(string GameName)
        {
            GameNameStr = GameName;
            InitializeComponent();
        }
    }
}
