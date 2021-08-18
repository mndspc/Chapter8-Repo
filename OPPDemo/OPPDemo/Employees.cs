using System;
using System.Collections;
using System.Collections.Generic;


namespace OPPDemo
{
    //  This class contains indexer of type Employee
    class Employees:IEnumerable<Employee>
    {
        List<Employee> employeelist = new List<Employee>();

        public Employee this[int i]
        {
            get
            {
                return employeelist[i];
            }
            set
            {
                employeelist.Insert(i,value);
                //employeelist.Add(value);
            }
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employeelist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
