using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Homework
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email : {message}");
        }
    }
}
