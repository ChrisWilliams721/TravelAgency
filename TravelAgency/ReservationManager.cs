using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class ReservationManager
    {
        public string AirlineName;
        public string Name;
        public string Citizenship;
        public string FlightNumber;
        public string ReservationCode;
        public string Day;
        public string Time;
        public string Cost;
        public ReservationManager(string reservationCode, string flightNumber, string name, string citizenship, string day, string time, string cost)
        {
            this.Name = name;
            this.Citizenship = citizenship;
            this.FlightNumber = flightNumber;
            this.ReservationCode = reservationCode;
            this.Day = day;
            this.Time = time;
            this.Cost = cost;

            
        }
        public override string ToString()
        {
            return $"reservationCode: {ReservationCode}, Airline Name: {AirlineName}, Name: {Name}, citizenship: {Citizenship}";
        }
    }
}

