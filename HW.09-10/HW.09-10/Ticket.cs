using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09_10
{
    class Ticket : Person
    {
        const string DepartureCountry = "Belarus";
        public string DestinationCountry { get; set; }
        public Guid TicketId { get; } 

        public Ticket()
        {
            TicketId = Guid.NewGuid();
            Console.WriteLine("Please input country of destination:");
            DestinationCountry = ValidateOfCountry(Console.ReadLine());
        }

        internal string ValidateOfCountry(string country)
        {
            while(country.Equals(string.Empty))
            {
                Console.WriteLine("Please input a correct country of destination:");
                country = Console.ReadLine();
            }
            return country;
        }

        internal static void GetInfo(Ticket ticket)
        {
            Console.WriteLine("You'r ticket details:");
            Console.WriteLine("Tickets Id: "+ticket.TicketId.ToString());
            Console.WriteLine("Passenger name: "+ticket.pasport.Name);
            Console.WriteLine("Flight: "+Ticket.DepartureCountry+"-"+ticket.DestinationCountry);
        }
    }
}