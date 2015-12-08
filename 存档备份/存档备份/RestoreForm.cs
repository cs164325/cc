using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace 存档备份
{
    public partial class RestoreForm : Form
    {
        string GameNameStr;
        string SavePathStr;
        public RestoreForm()
        {
            InitializeComponent();
        }
        public RestoreForm(string GameName,string SavePath)
        {
            GameNameStr = GameName;
            SavePathStr = SavePath;
            InitializeComponent();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = GameNameStr;
            string[] flag = SharedMethod.SelectDirectory(GameNameStr);
            for (int a = 0; a < flag.Length; a++)
            {
                comboBox1.Items.Add(flag[a]);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前名称'" + comboBox1.Text + "',确认还原存档?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                SharedMethod.RestoreSave(GameNameStr, comboBox1.Text, SavePathStr);
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            YesButton.Enabled = true;
        }
    }
}
