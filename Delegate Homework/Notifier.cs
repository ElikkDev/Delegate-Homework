using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Homework
{
    public delegate void NotificationHandler(string message);
    public class Notifier
    {
        public NotificationHandler? NotificationEvent;

        public void SendNotification(string message)
        {
            if (NotificationEvent != null)
                NotificationEvent(message);
            else
                Console.WriteLine("no subscribers");
        }
    }
}
