using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CarService.CarService)))
            {
                host.Open();
                Console.WriteLine("Host opened..");
                Console.ReadKey();
            }
        }
    }
}
