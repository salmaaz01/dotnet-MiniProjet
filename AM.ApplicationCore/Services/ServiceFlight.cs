using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Plane = AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight: Service<Flight>, IServiceFlight //elle herite men Service<Entity>, elle implemenre l'interface IServiceFlight
    {
        IUnitOfWork _unitOfWork;


        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;
        public List<Flight> Flights { get; set; } = new List<Flight>();



        
        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork) 
        {
            _unitOfWork = unitOfWork;

        }
        public void Add(Flight flight)
        {
            _unitOfWork.Repository<Flight>().Add(flight);
        }

        public void Remove(Flight flight)
        {
            _unitOfWork.Repository<Flight>().Delete(flight);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _unitOfWork.Repository<Flight>().GetAll();
        }


        public IList<DateTime> GetFlightDates(string dest)  /*pq IList*/
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination.Equals(dest))
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }
            return dates;
        }
        public IList<DateTime> GetFlightDates1(string dest)  /*pq IList*/
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (Flight f in Flights)
            {
                if (f.Destination.Equals(dest))
                {
                    dates.Add(f.FlightDate);
                }
            }
            return dates;
        }

        public void GetFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == (filterValue))
                            Console.WriteLine(f);
                    }
                    break;
                case "Date":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate.Equals(DateTime.Parse(filterValue)))
                            Console.WriteLine(f);
                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight f in Flights)
                    {
                        if (f.EstimatedDuration.Equals(int.Parse(filterValue)))
                            Console.WriteLine(f);
                    }
                    break;
            }





        }
        public IList<DateTime> GetFlightDates2(string dest)
        {
            /*var query = from f in Flights
                        where f.Destination == dest
                        select f.FlightDate;
            return query.ToList(); 
            /* onfait to list car query retourne type enumerable et
                nous on veut retourner une liste donc on fait tolist*/
            var reqLambda = Flights
                .Where(f => f.Destination == dest)
                .Select(f => f.FlightDate);
            return reqLambda.ToList();

        }

        public void ShowFlightDetails (Plane plane)
        {
            /*var req = from f in Flights
                      where f.MyPlane == plane
                      select f;

            foreach (var f in req)
            {
                Console.WriteLine(f.FlightDate + "" + f.Destination);
            }*/

            var reqLambda = Flights
                .Where(f => f.MyPlane == plane)
                .Select(f => f);
            foreach (var f in reqLambda)
            {
                Console.WriteLine(f.FlightDate + "" + f.Destination);
            }

        }

        public int ProggramedFlightNumber(DateTime startDate)
        {
            /*var req = from f in Flights
                      where (f.FlightDate - startDate).TotalDays < 7 && (f.FlightDate - startDate).TotalDays >0
                      select f;*/

            return (Flights
                     .Where(f=> (f.FlightDate - startDate).TotalDays < 7 && (f.FlightDate - startDate).TotalDays > 0)
                     .Select(f => f)).Count();
           

        }

        public double DurationAverage (string destination)
        {
            /*var req=from f in Flights
                    where f.Destination==destination
                    select f.EstimatedDuration;
             return req.Average();
            */

            return(Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.EstimatedDuration)).Average();
            
        }
        public IList<Flight> OrderedDurationFlights()
        {
           /* var req = from f in Flights 
                      orderby f.EstimatedDuration descending
                      select f;
            return req.ToList();*/

            return Flights.OrderByDescending(f=>f.EstimatedDuration).ToList();
                 



        }

       /* public IList<Traveller> SeniorTravellers(Flight flight)
        {
            
            /*var req = from j in flight.PassengerList.OfType<Traveller>()
                      orderby j.BirthDate                                       /*orderby par defaut ascending
                      select j;


            return req.Take(3).ToList();*/

           /* return (flight.PassengerList.OfType<Traveller>()
                .OrderBy(p=>p.BirthDate)
                .Take(3).ToList());

        }*/

        public void DestinationGroupedFlights()
        {
            var req = from f in Flights              /* IEnumerable feha read only  * ICollection timplementi men Enumerable w zeyda aaleh add w detelet * IList timplementi men ICollection w zeyda aaleha mecture par index*/
                     group f by f.Destination;

                     foreach (var g in req)
            {
                Console.WriteLine("Destination"+g.Key); /* key heya par quoi on a grouper la requete * dans notre cas key heya la destination*/
                foreach (var f in g )

                {
                    Console.WriteLine("Decollage : " + f.FlightDate);
                }

                
            }
        
        
        
        }
        public ServiceFlight()
        {
            /* FlightDetailsDel = ShowFlightDetails;
             DurationAverageDel= DurationAverage;*/
            DurationAverageDel = d =>
            {
                var req = from f in Flights
                          where (f.Destination == d)
                          select f.EstimatedDuration;
                return req.Average();

            };

            FlightDetailsDel = p =>
            {
                var req = from f in Flights
                          where f.MyPlane == p
                          select f;

                foreach (var f in req)
                {
                    Console.WriteLine(f.FlightDate + "" + f.Destination);
                }


            };





        }



    }
}




      

  
    


