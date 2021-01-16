using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceLib;
using System.ServiceModel;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Console based WCF host ***");

            using (var serviceHost = new ServiceHost(
                typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                DisplayHostInfo(serviceHost);

                Console.WriteLine("The service is ready...");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }

        private static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine("** Host info **");

            foreach(var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine($"Address: {endpoint.Address}");
                Console.WriteLine($"Binding: {endpoint.Binding.Name}");
                Console.WriteLine($"Contract: {endpoint.Contract.Name}");
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', 10));
        }
    }
}
