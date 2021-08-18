using System;
namespace OPPDemo
{
   public class Employee
    {   
        public int EmpCode { get; set; }
        public string  EmpName { get; set; }
        public string Email { get; set; }
        public Employee(int empCode,string empName,string email)
        {
            this.EmpCode = empCode;
            this.EmpName = empName;
            this.Email = email;
        }
        public override string ToString()
        {
            return string.Format("Code={0} Name={1} Email={2}", EmpCode, EmpName, Email);
        }

        public  static string ToString(Employee empObj)
        {
            return string.Format("Code={0} Name={1} Email={2}", empObj.EmpCode, empObj.EmpName, empObj.Email);
        }
    }
}
