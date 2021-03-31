using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Marathon
{
    static class Program
    {
        public static MySqlConnection connection = new MySqlConnection("server=" +
             "localhost;" +
             "user=root;" +
             "database=a0523665_artisTest;" +
             "password=");
        public static User userInfo = new User();
        public static MySqlDataReader sqlDataReader = null;
        public static string companyName = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
