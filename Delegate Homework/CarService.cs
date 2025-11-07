using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Homework
{
    public delegate void ServiceDelegate();
    public class CarService
    {
        public ServiceDelegate? ServiceChain;

        public void PerformServive()
        {
            if (ServiceChain != null)
                ServiceChain();

            else
                Console.WriteLine("No chains");
        }

        public void CheckOil()
        {
            Console.WriteLine("Yağ səviyyəsi yoxlanıldı");

        }

        public void CheckBrakes()
        {
            Console.WriteLine("Əyləc sistemi yoxlanıldı");
        }

        public void CheckEngine()
        {
            Console.WriteLine("Mühərrik vəziyyəti yoxlanıldı");
        }

        public void CheckLights()
        {
            Console.WriteLine("İşıq sistemi yoxlanıldı");
        }
    }
}
