namespace 存档备份
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.IsNewTime2 = new System.Windows.Forms.Label();
            this.IsNewTime1 = new System.Windows.Forms.Label();
            this.SaveFilesS = new System.Windows.Forms.Label();
            this.FilePath5 = new System.Windows.Forms.Label();
            this.FilePath4 = new System.Windows.Forms.Label();
            this.FilePath3 = new System.Windows.Forms.Label();
            this.FilePath2 = new System.Windows.Forms.Label();
            this.FilePath1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UPdateLabel2 = new System.Windows.Forms.Label();
            this.UpdateLabel1 = new System.Windows.Forms.Label();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手动备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Showtimer1 = new System.Windows.Forms.Timer(this.components);
            this.Hidetimer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 207);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "添加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 265);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RestoreButton);
            this.tabPage1.Controls.Add(this.IsNewTime2);
            this.tabPage1.Controls.Add(this.IsNewTime1);
            this.tabPage1.Controls.Add(this.SaveFilesS);
            this.tabPage1.Controls.Add(this.FilePath5);
            this.tabPage1.Controls.Add(this.FilePath4);
            this.tabPage1.Controls.Add(this.FilePath3);
            this.tabPage1.Controls.Add(this.FilePath2);
            this.tabPage1.Controls.Add(this.FilePath1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DelButton);
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.UPdateLabel2);
            this.tabPage1.Controls.Add(this.UpdateLabel1);
            this.tabPage1.Controls.Add(this.NameComboBox);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(142, 207);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(60, 23);
            this.RestoreButton.TabIndex = 17;
            this.RestoreButton.Text = "还原";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // IsNewTime2
            // 
            this.IsNewTime2.AutoSize = true;
            this.IsNewTime2.Location = new System.Drawing.Point(110, 184);
            this.IsNewTime2.Name = "IsNewTime2";
            this.IsNewTime2.Size = new System.Drawing.Size(23, 12);
            this.IsNewTime2.TabIndex = 16;
            this.IsNewTime2.Text = "   ";
            // 
            // IsNewTime1
            // 
            this.IsNewTime1.AutoSize = true;
            this.IsNewTime1.Location = new System.Drawing.Point(9, 184);
            this.IsNewTime1.Name = "IsNewTime1";
            this.IsNewTime1.Size = new System.Drawing.Size(95, 12);
            this.IsNewTime1.TabIndex = 15;
            this.IsNewTime1.Text = "按时间备份存档:";
            // 
            // SaveFilesS
            // 
            this.SaveFilesS.AutoSize = true;
            this.SaveFilesS.Location = new System.Drawing.Point(160, 60);
            this.SaveFilesS.Name = "SaveFilesS";
            this.SaveFilesS.Size = new System.Drawing.Size(23, 12);
            this.SaveFilesS.TabIndex = 14;
            this.SaveFilesS.Text = "   ";
            this.SaveFilesS.Click += new System.EventHandler(this.SaveFilesS_DoubleClick);
            // 
            // FilePath5
            // 
            this.FilePath5.AutoSize = true;
            this.FilePath5.Location = new System.Drawing.Point(9, 126);
            this.FilePath5.Name = "FilePath5";
            this.FilePath5.Size = new System.Drawing.Size(23, 12);
            this.FilePath5.TabIndex = 12;
            this.FilePath5.Text = "   ";
            this.FilePath5.Click += new System.EventHandler(this.FilePath2_DoubleClick);
            // 
            // FilePath4
            // 
            this.FilePath4.AutoSize = true;
            this.FilePath4.Location = new System.Drawing.Point(9, 111);
            this.FilePath4.Name = "FilePath4";
            this.FilePath4.Size = new System.Drawing.Size(23, 12);
            this.FilePath4.TabIndex = 12;
            this.FilePath4.Text = "   ";
            this.FilePath4.Click += new System.EventHandler(this.FilePath2_DoubleClick);
            // 
            // FilePath3
            // 
            this.FilePath3.AutoSize = true;
            this.FilePath3.Location = new System.Drawing.Point(9, 96);
            this.FilePath3.Name = "FilePath3";
            this.FilePath3.Size = new System.Drawing.Size(23, 12);
            this.FilePath3.TabIndex = 12;
            this.FilePath3.Text = "   ";
            this.FilePath3.Click += new System.EventHandler(this.FilePath2_DoubleClick);
            // 
            // FilePath2
            // 
            this.FilePath2.AutoSize = true;
            this.FilePath2.Location = new System.Drawing.Point(9, 81);
            this.FilePath2.Name = "FilePath2";
            this.FilePath2.Size = new System.Drawing.Size(23, 12);
            this.FilePath2.TabIndex = 11;
            this.FilePath2.Text = "   ";
            this.FilePath2.Click += new System.EventHandler(this.FilePath2_DoubleClick);
            // 
            // FilePath1
            // 
            this.FilePath1.AutoSize = true;
            this.FilePath1.Location = new System.Drawing.Point(9, 59);
            this.FilePath1.Name = "FilePath1";
            this.FilePath1.Size = new System.Drawing.Size(149, 12);
            this.FilePath1.TabIndex = 10;
            this.FilePath1.Text = "存档位置↓ 当前备份数量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "游戏名称:";
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(209, 207);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(60, 23);
            this.DelButton.TabIndex = 8;
            this.DelButton.Text = "删除";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(75, 207);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(60, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "修改";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UPdateLabel2
            // 
            this.UPdateLabel2.AutoSize = true;
            this.UPdateLabel2.Location = new System.Drawing.Point(97, 37);
            this.UPdateLabel2.Name = "UPdateLabel2";
            this.UPdateLabel2.Size = new System.Drawing.Size(23, 12);
            this.UPdateLabel2.TabIndex = 3;
            this.UPdateLabel2.Text = "   ";
            // 
            // UpdateLabel1
            // 
            this.UpdateLabel1.AutoSize = true;
            this.UpdateLabel1.Location = new System.Drawing.Point(9, 37);
            this.UpdateLabel1.Name = "UpdateLabel1";
            this.UpdateLabel1.Size = new System.Drawing.Size(83, 12);
            this.UpdateLabel1.TabIndex = 2;
            this.UpdateLabel1.Text = "上次游戏时间:";
            // 
            // NameComboBox
            // 
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(74, 12);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(195, 20);
            this.NameComboBox.TabIndex = 1;
            this.NameComboBox.SelectedIndexChanged += new System.EventHandler(this.NameComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(280, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "查看存档路径已失效游戏";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(284, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "存档备份";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.隐藏ToolStripMenuItem,
            this.手动备份ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // 手动备份ToolStripMenuItem
            // 
            this.手动备份ToolStripMenuItem.Name = "手动备份ToolStripMenuItem";
            this.手动备份ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.手动备份ToolStripMenuItem.Text = "手动备份";
            this.手动备份ToolStripMenuItem.Click += new System.EventHandler(this.手动备份ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Showtimer1
            // 
            this.Showtimer1.Interval = 1;
            this.Showtimer1.Tick += new System.EventHandler(this.Showtimer1_Tick);
            // 
            // Hidetimer1
            // 
            this.Hidetimer1.Interval = 1;
            this.Hidetimer1.Tick += new System.EventHandler(this.Hidetimer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "存档自动备份";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.Label UPdateLabel2;
        private System.Windows.Forms.Label UpdateLabel1;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FilePath2;
        private System.Windows.Forms.Label FilePath1;
        private System.Windows.Forms.Label FilePath3;
        private System.Windows.Forms.Label FilePath4;
        private System.Windows.Forms.Label FilePath5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label SaveFilesS;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer Showtimer1;
        private System.Windows.Forms.Timer Hidetimer1;
        private System.Windows.Forms.Label IsNewTime1;
        private System.Windows.Forms.Label IsNewTime2;
        private System.Windows.Forms.Button RestoreButton;
    }
}

