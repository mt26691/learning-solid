using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Dependency
{
    public class HPPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Hello from HP Printer");
        }
    }
}
