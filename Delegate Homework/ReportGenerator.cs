using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Homework
{
    public class ReportGenerator<T>
    {
        public delegate void ReportHandler(T data);

        public ReportHandler? ReportEvent;

        public void GenerateReport(T data)
        {
            if (ReportEvent != null)
                ReportEvent(data);

            else
                Console.WriteLine("Dont have any method");
        }
    }

    public class Reports
    {
       public void GenerateSalesReports(List<int> sales)
        {
            if(sales.Count == 0)
            {
                Console.WriteLine("No any sail");
                return;
            }

            double avg = 0;

            foreach(int s in sales)
            {
                avg += s;
            }

            avg /= sales.Count;
            Console.WriteLine(avg);
       }

        public void GenerateEmployeeReport(List<string> employees)
        {
            Console.WriteLine($"Count of employees : {employees.Count}");
            foreach (string e in employees)
            {
                Console.WriteLine($"Emplyees:{e} ");
            }   
        }

        public void GenerateErrorReport(List<string> errors)
        {
            Console.WriteLine("Xeta siyahisi:");
            foreach(string err in errors)
            {
                Console.WriteLine($"{err}");
            }
        }
    }
}
