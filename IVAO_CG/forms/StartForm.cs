using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IVAO_CG.scripts;
using MySql.Data.MySqlClient;

namespace IVAO_CG
{
    public partial class StartForm : Form
    {

        Sid _sid;
        Lists _sidlist;

        public StartForm()
        {
            InitializeComponent();
            _sid = new Sid();
            _sidlist = new Lists();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var airport = cb_airport.Text;

            string myConnectionString;

            myConnectionString = "server=server.roegl.eu;uid=ivao;" +
                "pwd=ivao_cg;database=ivao_cg;";


           

          
            try
            {
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM SID_LOVV WHERE AP = '" + airport + "'";
                MySqlDataReader rdr;
                connection.Open();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    
                    String row = "";
                    

                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        
                        row += rdr.GetValue(i).ToString() + ",";
                    }

                    string[] sarray = row.Split(new Char[] { ',' });

                    for(int y = 0; y<sarray.Length; ++y)
                    {
                        MessageBox.Show(sarray[y]);
                    }

                    _sid.name = sarray[0];
                    _sid.wapoint = sarray[1];
                    _sid.runway = Int32.Parse(sarray[2]);
                    _sid.airport = sarray[3];
                    _sid.isNoiseAb = bool.Parse(sarray[4]);

                    _sidlist.sidlist.Add(_sid);

                    
                                       
                  
                }
                connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
        
    }
}
