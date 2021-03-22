using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            SportBike bike = new SportBike();
            ushort maxSpeed = Motorcycle.MaxSpeedInternal;
            maxSpeed = Motorcycle.MaxSpeedPublic;
            maxSpeed = Motorcycle.MaxSpeedProtectedInternal;
            maxSpeed = SportBike.MaxSpeedInternal;
            maxSpeed = SportBike.MaxSpeedProtectedInternal;
            maxSpeed = SportBike.MaxSpeedPublic;
            //maxSpeed = Motorcycle.MaxSpeedPrivate;
            //Can be used only in the type where it's defined
            //maxSpeed = Motorcycle.MaxSpeedProtected;
            //Can be used only in the type where it's defined or in inherited types
            //maxSpeed = Motorcycle.MaxSpeedPrivateProtected;
            //Can be used only in the type where it's defined or in inherited types at the current assembly

            string vinNumber = moto.vinNumberInternal;
            vinNumber = moto.vinNumberPublic;
            vinNumber = moto.vinNumberProtectedInternal;
            vinNumber = bike.vinNumberInternal;
            vinNumber = bike.vinNumberProtectedInternal;
            vinNumber = bike.vinNumberPublic;
            //vinNumber = moto.vinNumberProtected;
            //vinNumber = moto.vinNumberPrivate;
            //vinNumber = moto.vinNumberPrivateProtected;

            moto.StartEnginePublic();
            moto.StartEngineInternal();
            moto.StartEngineProtectedInternal();
            bike.StartEngineProtectedInternal();
            bike.StartEnginePublic();
            bike.StartEngineInternal();
            //moto.StartEngineProtected();
            //moto.StartEnginePrivate();
            //moto.StartEnginePrivateProtected();

            bike.GetVinNum();
        }
    }
}
