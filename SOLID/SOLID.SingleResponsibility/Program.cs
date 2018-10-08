using System;

namespace SOLID.SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Add();
            Console.ReadLine();
        }
    }


    class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }

    class Customer
    {
        private FileLogger logger = new FileLogger();
        public virtual void Add()
        {
            try
            {
                Console.WriteLine("Customer is addeed to database");
            }
            catch (Exception ex)
            {
                // Lớp customer chỉ việc thêm customer vào database
                // Khi exception xảy ra, FileLogger sẽ có nhiệm vụ ghi
                // lại exception, lớp Customer không cần quan tâm về điều đó
                // Khi muốn thay đổi phương thức ghi log, như chuyển từ file txt
                // vào file Json hay database, bạn chỉ việc thay đổi lớp Logger
                logger.Handle(ex.ToString());
            }
        }
    }
}
