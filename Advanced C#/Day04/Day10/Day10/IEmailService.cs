using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public interface IEmailService
    {
        void SendEmail(Worker worker);
    }
}
