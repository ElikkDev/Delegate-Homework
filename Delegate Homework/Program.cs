using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate_Homework;

class Program
{
    static void Main()
    {
        Notifier notifier = new Notifier();

        EmailService emailService = new EmailService();
        PushNotificationService pushNotification = new PushNotificationService();
        SMSService sMSService = new SMSService();

        notifier.NotificationEvent += emailService.SendEmail;
        notifier.NotificationEvent += pushNotification.SendPush;
        notifier.NotificationEvent += sMSService.SendSMS;

        Console.WriteLine("Enter message:");
        string msg = Console.ReadLine();

        Console.WriteLine("First deliver:");
        notifier.SendNotification(msg);


        notifier.NotificationEvent -= sMSService.SendSMS;

        Console.WriteLine("Message after delivering");
        notifier.SendNotification(msg);



    

    }
}