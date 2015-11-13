using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace 存档备份
{
    class SharedMethod
    {
        public static DateTime GetLastWriteTime(string path)
        {
            DateTime maxdt = DateTime.MinValue;
            DateTime dt;
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var file in di.GetFiles("*",SearchOption.AllDirectories))
            {
                dt = file.LastWriteTime;
                if (maxdt < dt)
                {
                    maxdt = dt;
                }
            }
            return maxdt;
        }
        public static bool BackupSavaFile(string path,string name,bool IsNewTime)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                string SaveFilesName ;
                if (IsNewTime)
                {
                    SaveFilesName = DateTime.Now.ToString("yyyy-MM-dd HH点mm分ss");
                }
                else
                {
                    SaveFilesName = "NewSave";
                }
                string SaveFilesPath = Access.SavaFiles + name + "\\" + SaveFilesName;

                if (!Directory.Exists(SaveFilesPath))
                {
                    Directory.CreateDirectory(SaveFilesPath);
                }

                foreach (var file1 in di.GetFiles("*", SearchOption.AllDirectories))
                {
                    //截取子文件夹的路径
                    string flag2 = file1.DirectoryName.Remove(0,path.Length);

                    //备份文件夹+子文件夹路径
                    string flag3 = SaveFilesPath + flag2;

                    if (file1.DirectoryName != path)
                    {//假如当前文件路径在子文件夹下,创建子文件夹

                        if (!Directory.Exists(flag3))
                        {
                            Directory.CreateDirectory(flag3);
                        }
                    }
                    File.Copy(file1.FullName,flag3+"\\"+file1.Name,true);

                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool IsFiles(string gamename)
        {
            if (Directory.Exists(Access.SavaFiles + "\\" + gamename))
            {
                return true;
            }
            return false;
        }

        public static int SelectFiles(string path)
        {
            if(!Directory.Exists(path))
            {
                return 0;
            }
            DirectoryInfo di = new DirectoryInfo(path);
            return di.GetDirectories().Length;
        }
    }
}
