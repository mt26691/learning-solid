using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Dependency
{
    public class CanonPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Hello from HP CanonPrinter");
        }
    }
}
