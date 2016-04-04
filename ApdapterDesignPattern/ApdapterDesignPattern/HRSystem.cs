using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApdapterDesignPattern
{
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "121", "Deepak", "Team Leader" };
            employees[1] = new string[] { "232", "Loki", "Dev" };
            employees[2] = new string[] { "321", "Quang", "Dev" };
            employees[3] = new string[] { "432", "Chinh", "QC" };

            return employees;
        }       
    }
}
