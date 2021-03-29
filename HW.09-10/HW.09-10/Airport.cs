using System;

namespace HW._09_10
{
    class Airport
    {
        const string AirportName = "National Airport";
        internal static void Greeting()
        {
            int curretntHour = DateTime.Now.Hour;
            switch (curretntHour)
            {
                case int hour when hour >= 7 && hour < 12:
                    Console.WriteLine("Good morning!\nNice to see you at " + AirportName.ToString());
                    Console.WriteLine("Please introduce yourself:");
                    break;

                case int hour when hour >= 12 && hour < 17:
                    Console.WriteLine("Good day!\nNice to see you at " + AirportName.ToString());
                    Console.WriteLine("Please introduce yourself:");
                    break;

                case int hour when hour >= 17 && hour < 22:
                    Console.WriteLine("Good evening!\nNice to see you at " + AirportName.ToString());
                    break;

                case int hour when hour >= 22 && hour < 7:
                    Console.WriteLine("Good night!\nNice to see you at " + AirportName.ToString());
                    Console.WriteLine("Please introduce yourself:");
                    break;

                default:
                    Console.WriteLine("Good time of day!\nNice to see you at " + AirportName.ToString());
                    Console.WriteLine("Please introduce yourself:");
                    break;
            }

            Console.WriteLine(Console.ReadLine() + ",please, go to registration. ");
        }

        internal static Ticket Registration(out bool chek)
        {
            Ticket ticket = new Ticket();
            if (ticket.pasport.Expired < DateTime.Now)
                chek = false;
            else
                chek = true;
            return ticket;
        }

        internal static bool Security()
        {
            Console.WriteLine("Plese go through security!");
            Console.WriteLine("Are you carryng something forbidden?");
            string answer = Console.ReadLine().ToUpper();
            while (answer.Equals(string.Empty) || !answer.Equals("NO") && !answer.Equals("YES"))
            {
                Console.WriteLine("Please answer yes or no:");
                answer = Console.ReadLine().ToUpper();
            }

            if (answer.Equals("NO", StringComparison.Ordinal))
                return true;
            if (answer.Equals("YES", StringComparison.Ordinal))
                return false;
            else
                return false;
        }

        internal static bool PassportControl(Ticket ticket)
        {
            Console.WriteLine("Please go through passport control!");
            Console.WriteLine("Please input your name:");
            if (!Console.ReadLine().Equals(ticket.pasport.Name, StringComparison.Ordinal))
                return false;

            Console.WriteLine("Please input your passport number");
            if (!Console.ReadLine().Equals(ticket.pasport.Number, StringComparison.Ordinal))
                return false;

            Console.WriteLine("Please input your birth date:");
            bool chek = DateTime.TryParse(Console.ReadLine(), out DateTime birthDate);
            while (!chek)
            {       
                Console.WriteLine("Please input a correct date in dd.mm.yyyy format:");
                chek = DateTime.TryParse(Console.ReadLine(), out birthDate);
            }

            if (ticket.pasport.BirthDate != birthDate)
                return false;

            else
                return true;
        }
    }
}