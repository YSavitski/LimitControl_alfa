using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitControl_alfa
{
    public static class Program
    {
        public static SqlConnection IBMConn = Connection.GetConnection();
        public static string CurrentUser;
        public static int Access = 1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LimitsForm());


        }
    }
}
