using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApdapterDesignPattern
{
    public class EmployeeApdapter:HRSystem,ITarget
    {
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employeee in employees)
            {
                employeeList.Add(employeee[0]);
                employeeList.Add(",");
                employeeList.Add(employeee[1]);
                employeeList.Add(",");
                employeeList.Add(employeee[2]);
                employeeList.Add("\n");

            }
            return employeeList;
        }
    }
}
