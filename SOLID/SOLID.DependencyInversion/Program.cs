using System;
using System.Collections.Generic;

namespace SOLID.DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISender> senders = new List<ISender>();
            senders.Add(new EmailSender());
            senders.Add(new SMSSender());

            // Đến khi thực thi, lớp notification mới thực sự biết được nó sử dụng class mở rộng từ ISender nào.
            // Thông thường ta thực hiện điều này thông qua Dependency Injection pattern.
            Notification notification = new Notification(senders);
            notification.Send();
            Console.ReadLine();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class EmailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Send Email");
        }
    }

    public class SMSSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Send SMS");
        }
    }

    public class Notification
    {
        private ICollection<ISender> _senders;

        public Notification(ICollection<ISender> senders)
        {
            _senders = senders;
        }
        public void Send()
        {
            foreach (var message in _senders)
            {
                message.Send();
            }
        }
    }
}
