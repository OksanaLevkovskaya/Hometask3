using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int salary;
        public string allowedPass;
        public Employee(string fn, string ln, int sal, string pass)
        { 
            firstName = fn;
            lastName = ln;  
            salary = sal;
            allowedPass = pass; 
        }
        public string GetInformation()
        {
            return "Restaurant Employee is"  + firstName + lastName + salary + allowedPass;
        }
    }
}
