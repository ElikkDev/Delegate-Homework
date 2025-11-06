using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Homework
{
    public class PushNotificationService
    {
        public void SendPush(string message)
        {
            Console.WriteLine($"Push : {message}");
        }
    }
}
