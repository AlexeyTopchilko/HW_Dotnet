using System;

namespace HW._09_10
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Airport.Greeting();
            Ticket ticket = Airport.Registration(out bool chek);
            if (!chek)
            {
                Console.WriteLine("Flyght denied.");
                return;
            }
            chek = Airport.Security();
            if (!chek)
            {
                Console.WriteLine("Flyght denied.");
                return;
            }
            chek = Airport.PassportControl(ticket);
            if(!chek)
            {
                Console.WriteLine("Flyght denied.");
                return;
            }
            else
                Ticket.GetInfo(ticket);
        }
    }
}