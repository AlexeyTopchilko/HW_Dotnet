using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chopper chop = new Chopper();
            Motorcycle moto = new Motorcycle();
            //SportBike bike = new SportBike();    Class SportBike has an internal access level

            ushort maxSpeed = Motorcycle.MaxSpeedPublic;
            maxSpeed = Chopper.MaxSpeedPublic;
            //maxSpeed = Motorcycle.MaxSpeedProtectedInternal;       We can use here members of class
            //maxSpeed = Motorcycle.MaxSpeedInternal;                Only with Public access level
            //maxSpeed = Motorcycle.MaxSpeedPrivate;
            //maxSpeed = Motorcycle.MaxSpeedProtected;
            //maxSpeed = Motorcycle.MaxSpeedPrivateProtected
           
            string vinNumber = moto.vinNumberPublic;
            vinNumber = chop.vinNumberPublic;
            //vinNumber = moto.vinNumberInternal;
            //vinNumber = moto.vinNumberProtectedInternal;
            //vinNumber = moto.vinNumberProtected;
            //vinNumber = moto.vinNumberPrivate;
            //vinNumber = moto.vinNumberPrivateProtected;

            moto.StartEnginePublic();
            chop.StartEnginePublic();
            //moto.StartEngineInternal();
            //moto.StartEngineProtectedInternal();
            //moto.StartEngineProtected();
            //moto.StartEnginePrivate();
            //moto.StartEnginePrivateProtected();
        }
    }
}