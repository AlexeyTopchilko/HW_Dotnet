using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class MotorcycleRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>();
        public void Create(Motorcycle motorcycle)
        {
            if (motorcycle != null)
                _motorcycles.Add(motorcycle);
        }

        public void DeleteMotorcycle(int Id)
        {
            Motorcycle moto = _motorcycles.Find(motorcycle => motorcycle.Id == Id);
            _motorcycles.Remove(moto);
        }

        public Motorcycle GetMotorcycle(int Id)
        {
            Motorcycle moto = _motorcycles.Find(motorcycle => motorcycle.Id == Id);
            return moto;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return _motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }
    }
}
