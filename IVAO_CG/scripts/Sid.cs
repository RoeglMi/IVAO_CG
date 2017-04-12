using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVAO_CG.scripts
{
    public class Sid
    {

        public String name { get; set; }
        public String wapoint { get; set; }
        public Airport airport { get; set; }
        public int runway { get; set; }
        public Boolean isNoiseAb { get; set; }


        public List<Sid> sidlist = new List<Sid>();

                
    }

}
