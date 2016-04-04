using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new EmployeeApdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(target);
            client.ShowEmployeeList();

            Console.ReadKey();

        }
    }
}
