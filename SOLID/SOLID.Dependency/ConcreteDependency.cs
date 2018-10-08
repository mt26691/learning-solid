using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Dependency
{
    public class ConcreteDependency
    {
        public void Print()
        {
            // Lớp ConcreteDependency sử dụng trực tiếp lớp HP Printer
            HPPrinter worker = new HPPrinter();
            worker.Print();
        }
    }
}
