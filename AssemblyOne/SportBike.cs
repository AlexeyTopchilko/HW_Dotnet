using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike : Motorcycle
    {
        const ushort MaxSpeedProtect = Motorcycle.MaxSpeedProtected + 60;
        const ushort MaxSpeedPrivateProtect = Motorcycle.MaxSpeedPrivateProtected + 60;
        const ushort MaxSpeedProtectedInternal = Motorcycle.MaxSpeedProtectedInternal + 60;
        SportBike bike = new SportBike();
        internal void GetVinNum()
        {
            Console.WriteLine(bike.vinNumberProtected);
            Console.WriteLine(bike.vinNumberPrivateProtected);
            Console.WriteLine(bike.vinNumberProtectedInternal);
            bike.StartEnginePrivateProtected();
            bike.StartEngineProtected();
        }


    }
}