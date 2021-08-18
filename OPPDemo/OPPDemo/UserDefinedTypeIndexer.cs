using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDemo
{
    // This program demo. how to use user defined type indexer
    class UserDefinedTypeIndexer
    {
        static void Main()
        {

            Employees employees = new Employees();
            employees[0] = new Employee(100, "Scott", "scott@gmail.com");
            employees[1] = new Employee(101, "Tiger", "tiger@gmail.com");
            employees[0] = new Employee(102, "Smith", "smith@gmail.com");


            foreach (var employee in employees)
            {
                Console.WriteLine("code={0} Name={1} Email={2}",employee.EmpCode,employee.EmpName,employee.Email);

            }
            Console.ReadLine();
        }
    }
}
