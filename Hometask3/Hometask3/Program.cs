using System.Collections.Generic;
using System.Linq;

namespace Hometask3
{
    public class EmployeeComparerSal : IComparer<Employee>
    {
       
        public int Compare(Employee? x, Employee? y)
        {
           return x.salary.CompareTo(y.salary);

        }
    }
    public class Employees 
    {

        static void Main(string[] args)
        {
            Employee administrator = new Administrator ("Anna", "Shostak", 1000, "General");
            Employee waiter1 = new Waiter("Alex", "Sherstnev", 510, "General");
            Employee waiter2 = new Waiter("Dasha", "Vostreva", 520, "General");
            Employee waiter3 = new Waiter("Irina", "Rei", 530, "General");
            Employee cook = new Cook("Pavel", "Snup", 1500, "Kitchen");

            List <Employee> employeelist = new List<Employee>() { administrator,waiter1,waiter2,waiter3,cook};
            employeelist.Sort(new EmployeeComparerSal());

           

        }

    }
}