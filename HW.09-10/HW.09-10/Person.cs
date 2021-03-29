using System;

namespace HW._09_10
{
    class Person
    {
        internal Guid Id { get; }
        internal Pasport pasport;
        internal class Pasport
        {
            public string Number { get; set; }
            public DateTime Issued { get; set; }
            public DateTime Expired { get; set; }
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
        }

        internal Person()
        {
            pasport = new Pasport();
            Id = Guid.NewGuid();
            Console.WriteLine("Please input your name:");
            pasport.Name = ValidateName(Console.ReadLine());

            Console.WriteLine("Please input your birth date:");
            pasport.BirthDate = ValidateOfBirthDate(Console.ReadLine());

            Console.WriteLine("Please input your passport number");
            pasport.Number = ValidateNumber(Console.ReadLine());

            Console.WriteLine("Please input date of issue of pasport:");
            pasport.Issued = ValidateOfIssued(Console.ReadLine());

            Console.WriteLine("Please input your passport expiration date:");
            pasport.Expired = ValidateOfExpired(Console.ReadLine());
        }

        internal DateTime ValidateOfIssued(string issuedDate)
        {
            bool chek = DateTime.TryParse(issuedDate, out DateTime issued);
            while (!chek || issued >= DateTime.Now)
            {
                if (issued >= DateTime.Now)
                    Console.WriteLine("Good news,you are from the future!");
                Console.WriteLine("Please input a correct date in dd.mm.yyyy format:");
                chek = DateTime.TryParse(Console.ReadLine(), out issued);
            }
            return issued;
        }

        internal DateTime ValidateOfExpired(string expiredDate)
        {
            bool chek = DateTime.TryParse(expiredDate, out DateTime expired);
            while (!chek)
            {
                Console.WriteLine("Please input a correct date in dd.mm.yyyy format:");
                chek = DateTime.TryParse(Console.ReadLine(), out expired);
            }
            if (expired <= DateTime.Now)
            {
                Console.WriteLine("Sorry, you'r passport expired");
            }
            return expired;
        }

        internal DateTime ValidateOfBirthDate(string birthDatetxt)
        {
            bool chek = DateTime.TryParse(birthDatetxt, out DateTime birthDate);
            while (!chek || birthDate >= DateTime.Now)
            {
                if (birthDate >= DateTime.Now)
                    Console.WriteLine("Good news,you are from the future!");
                Console.WriteLine("Please input a correct date in dd.mm.yyyy format:");
                chek = DateTime.TryParse(Console.ReadLine(), out birthDate);
            }
            return birthDate;
        }

        internal string ValidateName(string name)
        {
            while (name.Equals(string.Empty))
            {
                Console.WriteLine("Please input a correct name:");
                name = Console.ReadLine();
            }
            return name;
        }

        internal string ValidateNumber(string number)
        {
            while (number.Equals(string.Empty))
            {
                Console.WriteLine("Please input a correct number:");
                number = Console.ReadLine();
            }
            return number;
        }
    }
}