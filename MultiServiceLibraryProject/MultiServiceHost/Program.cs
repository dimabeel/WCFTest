using MultiServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MultiServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CompanyService)))
            {
                host?.Open();
                Console.WriteLine($"Opened host...");
                Console.ReadKey();
            }
        }
    }
}
