using System;
using System.Collections.Generic;

namespace HW_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle("Yamaha", "Yamaha", 50);
            Motorcycle motorcycle1 = new Motorcycle("Java", "350", 30);
            Motorcycle motorcycle2 = new Motorcycle("Minsk", "Korito", 10);
            Motorcycle motorcycle3 = new Motorcycle("moped", "dvorovoj", 5);

            MotorcycleRepository motorepo = new MotorcycleRepository();
            motorepo.Create(motorcycle);
            motorepo.Create(motorcycle1);
            motorepo.Create(motorcycle2);
            motorepo.Create(motorcycle3);
            List<Motorcycle> motos = motorepo.GetMotorcycles();
            foreach (Motorcycle item in motos)
                item.GetCharacteristics();

            motorepo.DeleteMotorcycle(3);

            foreach (Motorcycle item in motos)
                item.GetCharacteristics();
        }
    }
}