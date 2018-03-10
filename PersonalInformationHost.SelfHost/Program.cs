using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PersonalInformationService;
using PersonalInformationService.ServiceImplementation;

namespace PersonalInformationHost.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            RunHost();
        }

        private static void RunHost()
        {
            using (var host = new ServiceHost(typeof(PersonalInfromationService)))
            {
                Console.WriteLine("Personal Infromation Service host starting");
                host.Open();
                Console.WriteLine("Press [ENTER] to stop service ...");
                Console.ReadLine();
            }
        }
    }
}
