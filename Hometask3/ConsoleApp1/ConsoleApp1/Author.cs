using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Author
    {
        string _firstname;
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value != null && value.Length <= 256)
                    _firstname = value;
                else
                    throw new Exception("FirstName Field is invalid");
            }
        }

        string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (value != null && value.Length <= 256)
                    _lastname = value;
                else
                    throw new Exception("LastName Field is invalid");
            }
        }

    }
}
