using System;

namespace OPPDemo
{
    //  This program demo. how to call overriden fun/virtual fun.
    class PolyDemo
    {
        static void Main()
        {
            MyMath1 myMath1 = new MyMath1();
            Console.WriteLine(myMath1.Increment(10));

            // How to call overriden version of ToStaring()
            Employee emp = new Employee(100, "Scott", "scott@gmail.com");
            Console.WriteLine(emp.ToString());

            // How to call shadowed version
            Console.WriteLine(myMath1.Add(34.6, 30.3));

            //  How to call shadow of ToString()
            Console.WriteLine(Employee.ToString(emp));

            Console.ReadLine();
        }
    }
}
