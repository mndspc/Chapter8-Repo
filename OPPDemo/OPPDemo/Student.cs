using System;

namespace OPPDemo
{
    class Student:IDisposable
    {
       
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //  The default constructor
        //public Student()
        //{
        //    Console.WriteLine("Default constructor of Student");
        //}
        //  The overloaded constructor
        public Student(int rollNo,string name,string email)
        {
            this.RollNo = rollNo;
            this.Name = name;
            this.Email = email;
        }
        public Student(Student student)
        {
            this.RollNo = student.RollNo;
            this.Name = student.Name;
            this.Email = student.Email;
        }
        public override string ToString()
        {
            return string.Format("Roll No={0}\tName={1}\tEmail={2}",RollNo,Name,Email);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
      
        ~Student()
        {
            
           System.Diagnostics.Debug.WriteLine("resources cleaned up");
        }   
    }
}
