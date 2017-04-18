using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVAO_CG.scripts
{
    public class Sid
    {

        public String name { get; set; }
        public String wapoint { get; set; }
        public String airport { get; set; }
        public int runway { get; set; }
        public Boolean isNoiseAb { get; set; }

    }

    public class Lists
    {

        public List<Sid> sidlist
        {
            get
            {
                return sidlist;
            }
            set
            {
                if (sidlist == null)
                {
                    sidlist = new List<Sid>();
                }
            }

        }
    }
}

