using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class EmailService : IEmailService
    {
        public void SendEmail(Worker worker)
        {
            Console.WriteLine($"Sending email to {worker.Name}");
        }
    }
}
