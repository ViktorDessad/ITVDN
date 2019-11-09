using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Viktor";
            string sName = "Sheresh";
            Employee employee = new Employee(fName, sName);
            employee.EmployeeSalary("Director", 12);
            Console.WriteLine(new string('*', 60));
            employee.EmployeeSalary("administrator", 7);
            Console.WriteLine(new string('*', 60));
            employee.EmployeeSalary("Worker", 3);
        }
    }
}
