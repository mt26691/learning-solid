using System;

namespace SOLID.Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is concrete Dependency");
            ConcreteDependency concreteDependency = new ConcreteDependency();
            concreteDependency.Print();

            Console.WriteLine("This is abstract Dependency");
            AbstractDependency abstractDependency = new AbstractDependency();
            IPrinter hpPrinter = new HPPrinter();
            IPrinter canonPrinter = new CanonPrinter();

            abstractDependency.Print(hpPrinter);
            abstractDependency.Print(canonPrinter);

            Console.ReadLine();
        }
    }
}
