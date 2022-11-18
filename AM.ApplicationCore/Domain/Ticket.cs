using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    { 
        public double Prix { get; set; }
        public int Siege { get; set; }
        public bool VIP { get; set; }
        //[ForeignKey("MyFlight")] //nom de la prop de navigation (nom de l'objet)
        public string PassengerFK { get; set; }

        public int FlightFK { get; set; }

        [ForeignKey("PassengerFK")]
        public Passenger MyPassenger { get; set; }

        [ForeignKey("FlightFK")]
        public Flight MyFlight { get; set; }
    }
}
