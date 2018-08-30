using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace HostCalculatorSerice
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService.CalculatorService))) {
                host.Open();
                Console.WriteLine("Host Started");
                Console.ReadLine();
            }
        }
    }
}
