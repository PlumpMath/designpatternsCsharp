using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApdapterDesignPattern
{
   public class ThirdPartyBillingSystem
    {
        private ITarget _employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSoure)
        {
            _employeeSource = employeeSoure;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = _employeeSource.GetEmployeeList();

            Console.WriteLine("######## Employee List #########");
            foreach( var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
