using System;

namespace ConsoleApplication21
{
    class NaszWyjatekException :System.Exception
    {

        public NaszWyjatekException() { }

        public NaszWyjatekException(string message) 
            : base(message)
        {

        }

        public NaszWyjatekException(string message, Exception innerException) 
          : base(message, innerException)
        {

        }
    }
}
