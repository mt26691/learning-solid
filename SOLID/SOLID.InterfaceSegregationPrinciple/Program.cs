using System;

namespace SOLID.InterfaceSegregationPrinciple
{
    public interface ILogin
    {
        bool Login(string username, string password);
        void Logout(string username);
    }
    public interface IRegister
    {
        Guid Register(string username, string password, string email);
    }
    public interface IForgotPassword
    {
        void ForgotPassword(string username);
    }

    public interface IMembership : ILogin, IRegister, IForgotPassword
    {
    }

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
