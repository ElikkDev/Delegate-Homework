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
        #region Task 1
        //Notifier notifier = new Notifier();

        //EmailService emailService = new EmailService();
        //PushNotificationService pushNotification = new PushNotificationService();
        //SMSService sMSService = new SMSService();

        //notifier.NotificationEvent += emailService.SendEmail;
        //notifier.NotificationEvent += pushNotification.SendPush;
        //notifier.NotificationEvent += sMSService.SendSMS;

        //Console.WriteLine("Enter message:");
        //string msg = Console.ReadLine();

        //Console.WriteLine("First deliver:");
        //notifier.SendNotification(msg);


        //notifier.NotificationEvent -= sMSService.SendSMS;

        //Console.WriteLine("Message after delivering");
        //notifier.SendNotification(msg);
        #endregion

        #region Task 2

        //Altdaki setri baxdim
        //Console.OutputEncoding = System.Text.Encoding.UTF8;

        //CarService car = new CarService();

        //Console.WriteLine("Avtomobil yoxlanma sistemi:");

        //Console.WriteLine("Check engine (y/n):");
        //string engine = Console.ReadLine();

        //Console.WriteLine("Check Lights (y/n):");
        //string light = Console.ReadLine();

        //Console.WriteLine("Check Brakes (y/n)");
        //string brake = Console.ReadLine();

        //Console.WriteLine("Check oil (y/n):");
        //string oil = Console.ReadLine();



        //if(oil.ToLower() == "y") car.ServiceChain += car.CheckEngine;
        //if(engine.ToLower() =="y")car.ServiceChain += car.CheckLights;
        //if(light.ToLower() == "y")car.ServiceChain += car.CheckBrakes;
        //if(brake.ToLower() == "y")car.ServiceChain += car.CheckOil;

        //car.PerformServive();


        #endregion

        #region Task 3

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Reports reports = new Reports();

        var salesReport = new ReportGenerator<List<int>>();
        salesReport.ReportEvent += reports.GenerateSalesReports;
        salesReport.GenerateReport(new List<int> { 100, 200, 300 });

        var employeeReport = new ReportGenerator<List<string>>();
        employeeReport.ReportEvent += reports.GenerateEmployeeReport;
        employeeReport.GenerateReport(new List<string> { "Rashad","Ali", "Elcan" });


        var errorReport = new ReportGenerator<List<string>>();
        errorReport.ReportEvent += reports.GenerateErrorReport;
        employeeReport.GenerateReport(new List<string> { "Server failed", "Login failed" });


        #endregion


    }
}   