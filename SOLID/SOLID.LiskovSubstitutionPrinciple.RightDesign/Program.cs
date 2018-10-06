using System;

namespace SOLID.LiskovSubstitutionPrinciple.RightDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            // staff là một kiểu của employee
            // do vậy có thể được sử dụng như employee
            IEmployee staff = new Staff();

            // manager cũng là một kiểu của employee
            IEmployee manager = new Manager();

            Console.WriteLine("Salary of staff = " + staff.CalculateSalary());
            Console.WriteLine("Salary of manager = " + manager.CalculateSalary());
            Console.ReadLine();
        }
    }

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
}
