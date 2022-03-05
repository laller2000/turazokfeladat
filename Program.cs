using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgatura
{
    static class Program
    {
        public static MySqlCommand sql = null;
        public static MySqlConnection conn = null;
        public static Form form_turazo = null;
        public static Form form_utvonal=null;
        public static Form form_turazofelvesz = null;

        
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "turazok";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException myex)
            {
                Console.WriteLine(myex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_turazo = new Form_Turazo();
            form_utvonal = new Form_Utvonal();
            form_turazofelvesz = new Form_Turazofelvesz();
            Application.Run(form_turazo);
        }
    }
}
