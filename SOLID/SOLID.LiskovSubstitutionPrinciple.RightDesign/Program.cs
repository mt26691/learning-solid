using System;

namespace SOLID.LiskovSubstitutionPrinciple.RightDesign
{
    public interface IEmployee
    {
        double CalculateSalary();
    }

    public class Staff : IEmployee
    {
        public double CalculateSalary()
        {
            return 10.0;
        }
    }

    public class Manager : IEmployee
    {
        public double CalculateSalary()
        {
            return 20.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEmployee staff = new Staff();
            IEmployee manager = new Manager();

            // staff và manager cùng thuộc một kiểu IEmployee
            // nên có thể được sử dụng như một IEmployee
            Console.WriteLine("Salary of staff = " + staff.CalculateSalary());
            Console.WriteLine("Salary of manager = " + manager.CalculateSalary());
            Console.ReadLine();
        }
    }
}
