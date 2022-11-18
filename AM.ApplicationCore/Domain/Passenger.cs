using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks; 

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {  /* public int Id { get; set; }*/

        [Display(Name = "DateOFBirth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAdress { get; set; }

        public FullName FullName { get; set; }

    [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set; }
       //  public ICollection<Flight> FlightList { get; set; }
        public ICollection<Ticket> TicketList { get; set; }

        public override string ToString()
        {
            return "First Name= " + FullName.FirstName + "Last Name= " + FullName.LastName;
        }

        /* public bool CheckProfile (string firstname,string lastname)
         {
             return FirstName == firstname && LastName == lastname;
         }
         public bool CheckProfile(string firstname, string lastname, string emailadresse)
         {
             return FirstName == firstname && LastName == lastname && EmailAdress == emailadresse;
         }*/
        public bool CheckProfile(string firstname, string lastname, string emailadresse = null)
        {
            if (emailadresse != null)
                return FullName.FirstName == firstname && FullName.LastName == lastname && EmailAdress == emailadresse;
            else
                return FullName.FirstName == firstname && FullName.LastName == lastname;
        }
         
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");

        }

    }


}

