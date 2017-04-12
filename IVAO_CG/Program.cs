using System;
using IVAO_CG.scripts;
using MySql.Data.MySqlClient;

namespace IVAO_CG
{
    class Program
    {


        static String connectionString = "SERVER=37.120.186.204;" +
                            "DATABASE=ivao_cg;" +
                            "UID=root;" +
                            "PASSWORD=Anja2017!;";

        [STAThread]
        static void Main()
        {

            DatabaseConnection();


        }


        static void DatabaseConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=server.roegl.eu;database=ivao_cg;uid=ivao;password=ivao_cg;");
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM SIDS_LOVV";
                MySqlDataReader Reader;


                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString() + ", ";
                    Console.WriteLine(row);
                }
                connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

    }
}
