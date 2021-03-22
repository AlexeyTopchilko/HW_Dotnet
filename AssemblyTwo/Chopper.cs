using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyTwo
{
    class Chopper : Motorcycle
    {
        const ushort MaxSpeedProtect = Motorcycle.MaxSpeedProtected - 40;
        const ushort MaxSpeedProtectedInternal = Motorcycle.MaxSpeedProtectedInternal - 40;
        Chopper chop = new Chopper();
        internal void GetVinNum()
        {
            Console.WriteLine(chop.vinNumberProtected);
            Console.WriteLine(chop.vinNumberProtectedInternal);
            chop.StartEngineProtected();
            chop.StartEngineProtectedInternal();
        }
    }
}