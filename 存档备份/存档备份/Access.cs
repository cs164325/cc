using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;
namespace 存档备份
{
    class Access
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteTransaction T;
        SQLiteDataAdapter da;
        string DataFile = Application.StartupPath + "\\SQLite.db";
        string SQLileFile = "Data Source=" + Application.StartupPath + "\\SQLite.db;Version=3;";
        public static string SavaFiles = Application.StartupPath + "\\备份存档\\";
        public Access()
        {
            try
            {
                if (!File.Exists(DataFile))
                {

                    conn = new SQLiteConnection(SQLileFile);
                    conn.Open();
                    cmd = new SQLiteCommand("CREATE TABLE GAME(NAME VARCHAR(50),UPDATETIME VARCHAR(50),FILEPATH VARCHAR(4000))", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cmd.Clone();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                Application.Exit();
            }
        }
        public bool Open()
        {
            try
            {
                if (!IsOpen())
                {
                    conn = new SQLiteConnection(SQLileFile);
                    conn.Open();
                    cmd = conn.CreateCommand();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return false;
            }
        }
        public bool IsOpen()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
        public bool Close()
        {
            try
            {
                if (IsOpen())
                {
                    conn.Close();
                    conn = null;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                return false;
            }
        }
        public int Command(string cmdstr)
        {
            try
            {
                T = conn.BeginTransaction();
                cmd.Transaction = T;
                cmd.CommandText = cmdstr;
                int a = cmd.ExecuteNonQuery();
                T.Commit();
                return a;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                T.Rollback();
                return -1;
            }
            finally
            {
                T.Dispose();
            }
        }

        public DataTable Select(string cmdstr)
        {
            DataTable dt = new DataTable();
            if (IsOpen())
            {
                
                da = new SQLiteDataAdapter(cmdstr, conn);
                da.Fill(dt);
                
            }
            return dt;
        }
    }
}
