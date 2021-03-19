using System;

namespace HW_11
{
    class Motorcycle
    {
        private static int count = 1;
        public int Id { get; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int Odometr { get; set; }

        public int Year { get;}

        public Motorcycle(string model, string manufacturer, int odometr)
        {
            Id = count;
            Year = DateTime.Now.Year;
            if (model.Equals(string.Empty))
                Model = "Unknown";
            else
                Model = model;
            if (manufacturer.Equals(string.Empty))
                Manufacturer = "Unknown";
            else
                Manufacturer = manufacturer;
            if (odometr > 100)
                Odometr = 100;
            else if (odometr < 0)
                Odometr = 0;
            else
                Odometr = odometr;
            count++;
        }

        public Motorcycle()
        {
            Id = count;
            Year = DateTime.Now.Year;
            Manufacturer = ValidateManufacturer();
            Model = ValidateModel();
            Odometr = ValidateOdometr();
            count++;
        }
        public string ValidateModel()
        {
            Console.WriteLine("Input model of motorcycle: ");
            string model = Console.ReadLine();
            if (model.Equals(string.Empty))
                model = "Unknown";
            return model;
        }
        public string ValidateManufacturer()
        {
            Console.WriteLine("Input a manufactorer: ");
            string manufacturer = Console.ReadLine();
            if (manufacturer.Equals(string.Empty))
                manufacturer = "Unknown";
            return manufacturer;
        }

        public int ValidateOdometr()
        {
            Console.WriteLine("Input an odometr: ");
            bool chek = Int32.TryParse(Console.ReadLine(), out int odometr);
            while (!chek || odometr > 100 || odometr < 0)
            {
                Console.WriteLine("Please input correct value of odometr");
                chek = Int32.TryParse(Console.ReadLine(), out odometr);
            }
            return odometr;
        }

        public void GetCharacteristics()
        {
            Console.Write("Id: "+Id.ToString()+" Manufacturer: "+Manufacturer.ToString()
                       +" Model: "+Model.ToString()+" Odometr: "+Odometr.ToString()+"\n");
        }
    }
}