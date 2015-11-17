using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.OleDb;
namespace cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.增加IsNewTime列");

            int a = 0;
            while (a == 0)
            {
                int.TryParse(Console.ReadLine(), out a);
            }
            switch (a)
            {
                case 1:
                    SQLiteConnection conn = new SQLiteConnection("Data Source=" + Environment.CurrentDirectory + "\\SQLite.db;Version=3;");
                    SQLiteCommand cmd = new SQLiteCommand("ALTER TABLE GAME ADD ISNEWTIME VARCHAR(50)",conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE GAME SET ISNEWTIME = 'False'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
