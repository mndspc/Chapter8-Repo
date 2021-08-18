using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace OPPDemo
{
    //  This program demo. how to work with constructor
    class ConstructorDemo
    {
        static void Main()
        {
         
            // To call Default constructor
            // To create quickly disposable object
            using (Student std = new Student(200, "Scott", "scott@gmail.com"))
            {
                Console.WriteLine(std.ToString());
                //  To call copy constructor
                using (Student std1 = new Student(std))
                {
                    Console.WriteLine("RollNo={0}\tName={1}\tEmail={2}", std1.RollNo, std1.Name, std1.Email);
                }
            }
      
            Console.ReadLine();
        }
    }
}
