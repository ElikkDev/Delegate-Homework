using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Homework
{
    public class SMSService
    {
        public void SendSMS(string message)
        {
            Console.WriteLine($"Sms : {message}");
        }
    }
}
