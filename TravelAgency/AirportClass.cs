using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class AirportClass
    {
        public string AirportCode;
        public string AirportName;

        public AirportClass(string airportCode, string airportName)
        {
            this.AirportCode = airportCode;
            this.AirportName = airportName;
        }

        public virtual void ToString()
        {
        
        }
    }
}

