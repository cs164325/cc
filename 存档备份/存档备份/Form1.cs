﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 存档备份
{
    public partial class Form1 : Form
    {
        Access ac;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 3500;
            ac = new Access();
            updateDGV();
            Save();
        }

        public void updateDGV()
        {
            ac.Open();
            NameComboBox.Items.Clear();
            WipeLabel();
            dataGridView1.DataSource = ac.Select("select name as 游戏名称,updatetime as 上次游戏时间  from game");
            DataTable dt = ac.Select("select * from game");
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                NameComboBox.Items.Add(dt.Rows[a]["name"].ToString());
            }
            ac.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm ();
            af.StartPosition = FormStartPosition.CenterParent;
            if (af.ShowDialog() == DialogResult.Yes)
            {
                updateDGV();
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameComboBox.Text != "")
            {
                string filepath = NameComboBox.Text;
                AddForm af = new AddForm(NameComboBox.Text);
                af.StartPosition = FormStartPosition.CenterParent;
                if (af.ShowDialog() == DialogResult.Yes)
                {
                    updateDGV();
                    NameComboBox.SelectedIndex = NameComboBox.Items.IndexOf(filepath);
                }
            }
        }
        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameComboBox.Text != "")
            {
                ac.Open();
                DataTable dt = ac.Select("select * from game where name ='"+NameComboBox.Text+"'");
                UPdateLabel2.Text = dt.Rows[0]["updatetime"].ToString();
                UpdateFilePathLabel(dt.Rows[0]["filepath"].ToString());
                SaveFilesS.Text = SharedMethod.SelectFiles(Access.SavaFiles + dt.Rows[0]["name"].ToString()).ToString();
                IsNewTime2.Text = dt.Rows[0]["isnewtime"].ToString();
                ac.Close();
            }
        }
        public void UpdateFilePathLabel(string path)
        {
            int flag = 40;
            if (path.Length < flag)
            {
                FilePath2.Text = path;
                FilePath3.Text = "";
                FilePath4.Text = "";
                FilePath5.Text = "";
            }
            else if (path.Length < (flag * 2))
            {
                FilePath2.Text = path.Substring(0, flag);
                FilePath3.Text = path.Substring(flag);
                FilePath4.Text = "";
                FilePath5.Text = "";
            }
            else if (path.Length < (flag * 3))
            {
                FilePath2.Text = path.Substring(0, flag);
                FilePath3.Text = path.Substring(flag, flag);
                FilePath4.Text = path.Substring(flag * 2);
                FilePath5.Text = "";
            }
            else
            {
                FilePath2.Text = path.Substring(0, flag);
                FilePath3.Text = path.Substring(flag, flag);
                FilePath4.Text = path.Substring(flag * 2,flag);
                FilePath5.Text = path.Substring(flag * 3);
            }
        }
        public void WipeLabel()
        {
            UPdateLabel2.Text = "";
            FilePath2.Text = "";
            FilePath3.Text = "";
            FilePath4.Text = "";
            FilePath5.Text = "";
            SaveFilesS.Text = "";
            IsNewTime2.Text = "";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (NameComboBox.Text != "")
            {
                if (MessageBox.Show("当前游戏名称'"+NameComboBox.Text+"',确认删除?", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    ac.Open();
                    int cmdflag = ac.Command("delete from game where name = '" + NameComboBox.Text + "'");
                    if (cmdflag != -1)
                    {
                        MessageBox.Show( "删除成功!","提示");
                        updateDGV();
                    }
                    else
                    {
                        MessageBox.Show( "删除失败!","提示");
                        updateDGV();
                    }
                    ac.Close();
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void 手动备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Save();
        }
        public void Save()
        {
            string shixiaogamename = "";
            notifyIcon1.ShowBalloonTip(5000, "提示", "开始备份", ToolTipIcon.Info);
            ac.Open();
            DataTable dt = ac.Select("select * from game");
            for (int a = 0;a < dt.Rows.Count; a++)
            {
                string name;
                DateTime SaveTime;
                string filepath;
                DateTime LastSaveTime;
                bool isnewtime;

                name = dt.Rows[a]["name"].ToString();
                SaveTime = Convert.ToDateTime(dt.Rows[a]["UPDATETIME"].ToString());
                filepath = dt.Rows[a]["filepath"].ToString();
                isnewtime = dt.Rows[a]["isnewtime"].ToString() == "True" ? true : false;
                if (Directory.Exists(filepath) == false)
                {//假如存档位置不存在
                    ac.Command("update game set filepath = '' where name = '" + name + "'");
                    shixiaogamename = shixiaogamename+name;
                    continue;
                }

                LastSaveTime = Convert.ToDateTime(SharedMethod.GetLastWriteTime(filepath).ToString());
                if (SaveTime < LastSaveTime || !SharedMethod.IsFiles(name))
                {//保存最后一次游戏存档
                    SharedMethod.BackupSavaFile(filepath,name,isnewtime);
                    ac.Command("update game set updatetime = '"+LastSaveTime.ToString()+"' where name = '" + name + "'");
                    notifyIcon1.ShowBalloonTip(5000, "提示", "" + name + "存档备份成功", ToolTipIcon.Info);  
                }
                  
            }
            if (shixiaogamename != "")
            {
                notifyIcon1.ShowBalloonTip(10000, "提示", "备份完成,"+shixiaogamename+"路径失效请及时修改", ToolTipIcon.Info);
            }
            else
            {
                notifyIcon1.ShowBalloonTip(5000, "提示", "备份完成", ToolTipIcon.Info);
            }
            ac.Close();
            updateDGV();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                ac.Open();
                dataGridView1.DataSource = ac.Select("select name as 游戏名称 from game where filepath = ''");
                ac.Close();
            }
            else
            {
                updateDGV();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void Showtimer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity = this.Opacity + 0.01;
            }
            else
            {
                Showtimer1.Enabled = false;
            }
        }
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);
            this.Left = rect.Width / 3;
            this.Top = rect.Height / 3;
            this.Show();
            Showtimer1.Enabled = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hidetimer1.Enabled = true;
        }

        private void Hidetimer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >0)
            {
                this.Opacity = this.Opacity - 0.01;
            }
            else
            {
                this.Hide();
                Hidetimer1.Enabled = false;
            }
        }

    }
}
