using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpTutorial
{
    internal class Employee
    {
        //constructor are used to assign value to instance variable
        //constructor name should be same as classname
        public int empId;
        public string empName;
        public string empRole;
        public static string companyName ;



        public Employee(int empId, string empName, string empRole)
        {
            this.empId = empId;
            this.empName = empName;
            this.empRole = empRole;
        }

        static Employee()
        {
            companyName = "Mismo Software";
        } 
        public void printEmployeeDeatils()
        {
            Console.WriteLine("Employee ID-:"+empId);
            Console.WriteLine("Employee Name-:" + empName);
            Console.WriteLine("Employee Role-:" + empRole);

        }
    }
}
