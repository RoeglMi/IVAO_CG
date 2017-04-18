using System;
using IVAO_CG.scripts;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace IVAO_CG
{
    class Program
    {

        
    
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());

        }
        
    }
}
