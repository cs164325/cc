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
        public static bool BackupSavaFile(string path,string name,int SaveFlag)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                string SaveFilesName ;
                switch (SaveFlag)
                {
                    case 1:
                        SaveFilesName = DateTime.Now.ToString("yyyy-MM-dd HH点mm分ss");
                        break;
                    case 2:
                        SaveFilesName = "NewSave";
                        break;
                    default:
                        SaveFilesName = "NewSave";
                        break;
                }
                string SaveFilesPath = Access.SavaFiles + name + "\\" + SaveFilesName;

                if (!Directory.Exists(SaveFilesPath))
                {
                    Directory.CreateDirectory(SaveFilesPath);
                }
                else
                {
                    Directory.Delete(SaveFilesPath, true);
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
            if (Directory.Exists(Access.SavaFiles + gamename))
            {
                return true;
            }
            return false;
        }

        public static int SelectFiles(string gamename)
        {
            string FilePath = Access.SavaFiles + gamename;
            if(!Directory.Exists(FilePath))
            {
                return 0;
            }
            DirectoryInfo di = new DirectoryInfo(FilePath);
            return di.GetDirectories().Length;
        }
        public static string[] SelectDirectory(string gamename)
        {
            string FilePatg = Access.SavaFiles + gamename;
            DirectoryInfo di = new DirectoryInfo(FilePatg);
            DirectoryInfo[] DiIn  = di.GetDirectories();
            string[] flag = new string[DiIn.Length];
            for (int a = 0; a < DiIn.Length; a++)
            {
                flag[a] = DiIn[a].Name;
            }
            return flag;
        }
        public static bool RestoreSave(string GameName,string SavesName,string SavePath)
        {
            try
            {
                string BackupsFilePath = Access.SavaFiles + GameName + "\\" + SavesName;
                if (Directory.Exists(SavePath))
                {
                    Directory.Move(SavePath, SavePath + "1");
                    Directory.CreateDirectory(SavePath);
                }
                DirectoryInfo di = new DirectoryInfo(BackupsFilePath);
                foreach (var file1 in di.GetFiles("*", SearchOption.AllDirectories))
                {
                    //截取备份存档子文件夹的路径
                    string flag2 = file1.DirectoryName.Remove(0, BackupsFilePath.Length);

                    //存档文件夹+子文件夹路径
                    string flag3 = SavePath + flag2;

                    if (file1.DirectoryName != BackupsFilePath)
                    {//假如当前文件路径在子文件夹下,创建子文件夹

                        if (!Directory.Exists(flag3))
                        {
                            Directory.CreateDirectory(flag3);
                        }
                    }
                    File.Copy(file1.FullName, flag3 + "\\" + file1.Name, true);
                }
                Directory.Delete(SavePath+"1",true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }
                Directory.Move(SavePath, SavePath.Substring(0, SavePath.Length - 1));
                return false;
            }
        }

        public static bool IsSaveFile(string path)
        {
            return Directory.Exists(path);
        }
    }
}
