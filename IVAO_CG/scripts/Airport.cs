using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVAO_CG.scripts
{
    public class Airport
    {
        public string name { get; set; }
        public string fir { get; set;}
        public Boolean isModeS { get; set; }


        public List<Airport> airportlist = new List<Airport>();

    }
}
