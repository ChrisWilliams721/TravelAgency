using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Flight
    {
        public string Origin;
        public string Destination;
        public string DayOfWeek;
        public string FlightNumber;
        public string AirlineName;
        public string FlightTime;
        public string FlightCost;
        public string FlightDistance;

        public Flight(string origin, string destination, string dayOfWeek, string flightNumber, string airlineName, string flightTime, string flightCost, string flightDistance)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.DayOfWeek = dayOfWeek;
            this.FlightNumber = flightNumber;
            this.AirlineName = airlineName;
            this.FlightTime = flightTime;
            this.FlightCost = flightCost;
            this.FlightDistance = flightDistance;
        }
        public override string ToString()
        {
            return $"Flight Number: {FlightNumber}, Airline Name: {AirlineName}, Origin: {Origin}, Destinition: {Destination}, Day: {DayOfWeek}, Flight Time: {FlightTime}, Flight cost: {FlightCost} Flight distince {FlightDistance}";
        }
    }
}

