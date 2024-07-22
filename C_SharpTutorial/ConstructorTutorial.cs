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
        private int _empId;
        private string _empName;
        private string _empRole;
        private static string _companyName ;

        public int EmpId
        {
            set { _empId = value; }
            get { return _empId; }
        }

        public string CompanyName
        {
            set { _companyName = value; }
            get { return _companyName; }
        }


        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }

        // Property for EmpRole
        public string EmpRole
        {
            set { _empRole = value; }
            get { return _empRole; }
        }


        public Employee(int empId, string empName, string empRole)
        {
            this._empId = empId;
            this._empName = empName;
            this._empRole = empRole;
        }

        static Employee()
        {
            _companyName = "Mismo Software";
        } 
        public void printEmployeeDeatils()
        {
            Console.WriteLine("Employee ID-:"+_empId);
            Console.WriteLine("Employee Name-:" + _empName);
            Console.WriteLine("Employee Role-:" + _empRole);

        }
    }
}
