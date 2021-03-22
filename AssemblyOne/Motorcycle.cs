using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeedPublic = 300;
        internal const ushort MaxSpeedInternal = 300;
        private const ushort MaxSpeedPrivate = 300;
        protected const ushort MaxSpeedProtected = 300;
        protected internal const ushort MaxSpeedProtectedInternal = 300;
        private protected const ushort MaxSpeedPrivateProtected = 300;

        internal string vinNumberInternal = "1V232G-69GG-A45T";
        private string vinNumberPrivate = "1V232G-69GG-A45T";
        public string vinNumberPublic = "1V232G-69GG-A45T";
        protected string vinNumberProtected = "1V232G-69GG-A45T";
        protected internal string vinNumberProtectedInternal = "1V232G-69GG-A45T";
        private protected string vinNumberPrivateProtected = "1V232G-69GG-A45T";

        public void StartEnginePublic()
        {
        }

        internal void StartEngineInternal()
        {
        }

        protected void StartEngineProtected()
        {
        }

        private void StartEnginePrivate()
        {
        }

        protected internal void StartEngineProtectedInternal()
        {
        }

        private protected void StartEnginePrivateProtected()
        {
        }
    }
}