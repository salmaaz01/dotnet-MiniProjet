using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filtertype, string destination);
        public IList<DateTime> GetFlightDates1(string destination);
        public IList<DateTime> GetFlightDates2(string destination);
        void ShowFlightDetails(Plane plane);
        IList<Flight> OrderedDurationFlights();
        public void DestinationGroupedFlights();
        //void DestinationGroupedFlights();
       // void Add(Flight flight);
        //void Remove(Flight flight);
       // IEnumerable<Flight> GetAll();
    }

}
