using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Waiter : Employee

    {
        public Waiter(string fn, string ln, int sal, string pass) : base(fn, ln, sal, pass)
        {
            lastName = ln;
            firstName = fn;
            salary = sal;
            allowedPass = pass;
        }

    }
}
