using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane p1 = new Plane()
        {
            Capacity = 150,
            PlaneType = PlaneType.Boing,
            ManufactureDate = new DateTime(2015, 02, 03)
        };
        public static Plane p2 = new Plane()
        {
            Capacity = 250,
            PlaneType = PlaneType.Airbus,
            ManufactureDate = new DateTime(2020, 11, 11)
        };

        public static Staff s = new Staff()
        {FullName = new FullName
        {
            FirstName = "captain",
            LastName = "captain",
        },
            EmailAdress="captain.captain@gamail.com",
            BirthDate=new DateTime(1965,01,01),
            EmploymentDate=new DateTime(1999,01,01),
            Salary=99999

        };
        public static Staff s2 = new Staff()
        {
            FullName = new FullName
            {
                FirstName = "hostess",
                LastName = "hostess1",
            },
            EmailAdress = "hostess1.hostess1@gamail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        public static Staff s3 = new Staff()
        {
            FullName = new FullName
            {
                FirstName = "hostess2",
                LastName = "hostess2",
            },
            EmailAdress = "hostess2.hostess2@gamail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };

        public static Traveller t1 = new Traveller()
        {
            FullName = new FullName
            {
                FirstName = "traveller1",
                LastName = "traveller1",
            },
            EmailAdress = "traveller1.traveller1@gamail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No troubels",
            Nationality = "American"

        };
        public static Traveller t2 = new Traveller()
        {
            FullName = new FullName
            {
                FirstName = "traveller2",
                LastName = "traveller2",
            },
            EmailAdress = "traveller2.traveller2@gamail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some troubels",
            Nationality = "French"

        };
        public static Traveller t3 = new Traveller()
        {
            FullName = new FullName
            {
                FirstName = "traveller3",
                LastName = "traveller3",
            },
            EmailAdress = "Traveller3.Traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No Troubles",
            Nationality = "Tunisia"

        };
        public static Traveller t4 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller4",
                LastName = "traveller4",
            },
            EmailAdress = "Traveller4.Traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "Some Troubles",
            Nationality = "American"
        };
        public static Traveller t5 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller5",
                LastName = "traveller5",
            },
            EmailAdress = "Traveller5.Traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some Troubles",
            Nationality = "Spanish"
        };

        public static Flight f1 = new Flight()
        {

            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01),
            MyPlane = p2   ,
            EstimatedDuration = 110,
           /* PassengerList=new List<Passenger>()
            { t2,t2,t3,t4,t5}*/


        };
        public static Flight f2 = new Flight()
        {
            FlightDate= new DateTime(2022,02,01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01),
            MyPlane = p1,
            EstimatedDuration = 105,
        };
        public static Flight f3 = new Flight()
        {
            FlightDate = new DateTime(2022, 03, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01),
            MyPlane = p1,
            EstimatedDuration = 100,

        };
        public static Flight f4 = new Flight
        {
            FlightDate = new DateTime(2022, 04, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01),
            MyPlane = p1,
            EstimatedDuration = 130,

        };
        public static Flight f5 = new Flight
        {
            FlightDate = new DateTime(2022, 05, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01),
            MyPlane = p1,
            EstimatedDuration = 105,

        };
        public static Flight f6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 06, 01),
            MyPlane = p2,
            EstimatedDuration = 200,

        };
        public static List<Flight> listFlights=new List<Flight>
        { f1,f2,f3,f4,f5,f6};


    }
}
