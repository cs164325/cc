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
    public partial class AddForm : Form
    {
        string GameName = "";
        public AddForm()
        {
            this.Text = "添加";
            InitializeComponent();
        }
        public AddForm(string name)
        {
            this.Text = "修改";
            GameName = name;
            InitializeComponent();
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.Text = "已选择";
                toolTip1.SetToolTip(button1, folderBrowserDialog1.SelectedPath);
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameTextBox.Text.Trim();
                string filepath = folderBrowserDialog1.SelectedPath;
                string updatetime = SharedMethod.GetLastWriteTime(folderBrowserDialog1.SelectedPath).ToString();
                string isnewtime = IsNewTimeCheckBox.Checked.ToString();
                Access ac = new Access();
                ac.Open();
                if (this.Text == "添加")
                {
                    DataTable dt = ac.Select("select * from game where name = '" + name + "'");
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("提示", "该游戏名称已存在");
                        return;
                    }
                    ac.Command("insert into game(name,updatetime,filepath,isnewtime) values('" + name + "','" + updatetime + "','" + filepath + "','" + isnewtime + "')");
                    if (SharedMethod.SelectFiles(name) != 0)
                    {
                        if (MessageBox.Show("当前游戏有曾备份的存档文件,是否还原?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            
                            RestoreForm rf = new RestoreForm(name,filepath);
                            rf.StartPosition = FormStartPosition.CenterParent;
                            this.Opacity = 0;
                            rf.ShowDialog();
                        }
                    }
                }
                else if (this.Text == "修改")
                {
                    ac.Command("update game set filepath = '" + filepath + "' ,updatetime = '" + updatetime + "' ,isnewtime = '" + isnewtime + "' where name = '" + name + "'");
                }
                ac.Close();
            }
            catch
            {
 
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            JC();
        }
        public void JC()
        {
            if (NameTextBox.Text == "" || folderBrowserDialog1.SelectedPath == "")
            {
                YesButton.Enabled = false;
            }
            else if (NameTextBox.Text != "" && folderBrowserDialog1.SelectedPath != "")
            {
                YesButton.Enabled = true;
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (GameName != "")
            {
                Access ac = new Access();
                ac.Open();
                DataTable dt = ac.Select("select * from game where name = '"+GameName+"'");
                NameTextBox.Text = dt.Rows[0]["name"].ToString();
                if (dt.Rows[0]["filepath"].ToString() != "")
                {
                    folderBrowserDialog1.SelectedPath = dt.Rows[0]["filepath"].ToString();
                    toolTip1.SetToolTip(button1, folderBrowserDialog1.SelectedPath);
                    button1.Text = "已选择";
                }
                IsNewTimeCheckBox.Checked = dt.Rows[0]["isnewtime"].ToString() == "True"? true:false;
                NameTextBox.Enabled = false;
                ac.Close();
            }
        }

    }
}
