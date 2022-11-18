// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");
Plane p1=new Plane();
p1.Capacity = 300;
p1.ManufactureDate = new DateTime(1998, 01, 18);
p1.PlaneType = PlaneType.Airbus;
Console.WriteLine(p1.ToString());

Plane p2=new Plane(PlaneType.Boing,300,DateTime.Now);
Console.WriteLine(p2.ToString());

Plane p3 = new Plane()
{
    Capacity = 4,
    PlaneType = PlaneType.Boing,
    ManufactureDate = DateTime.Now


};
Console.WriteLine(p3.ToString());

Passenger pass1 = new Passenger()
{FullName= new FullName
{
    FirstName = "Salma",
    LastName = "Azaiez"
},
    EmailAdress = "salma.azaiez@esprit.tn"
};

ServiceFlight SF = new ServiceFlight();
SF.Flights=TestData.listFlights;

foreach (var item in SF.GetFlightDates1("Paris"))
{ Console.WriteLine(item); }

SF.GetFlights("Destination", "Paris");
Console.WriteLine("details de l'avion");
SF.ShowFlightDetails(TestData.p2);
Console.WriteLine(SF.DurationAverage("Madrid"));

/*foreach (var f in SF.SeniorTravellers(TestData.f1))
{ Console.WriteLine(f); }
Console.WriteLine("les vols par destination :");
SF.DestinationGroupedFlights();*/

AMContext Context = new AMContext(); //On fait l'instanciation de contexte khater fih les dbset
Context.Flights.Add(TestData.f3); //on ajoute un flight fel dbset
Context.SaveChanges();
Console.WriteLine(Context.Flights.First().MyPlane.Capacity);




