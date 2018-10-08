using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Dependency
{
    public class AbstractDependency
    {
        public void Print(IPrinter printer)
        {
            // Lớp AbstractDependency sử dụng sự trừ tượng (Interface) là IPrinter
            printer.Print();
        }
    }
}
