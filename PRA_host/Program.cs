using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace PRA_host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(wcf_pra.Service_pra)))
            {
                host.Open();
                Console.WriteLine("Host start");
                Console.ReadLine();
            }
        }
    }
}
