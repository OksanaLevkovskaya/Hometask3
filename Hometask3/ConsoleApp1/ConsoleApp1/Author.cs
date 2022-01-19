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
                if (_firstname != null && _firstname.Length < 256)
                    return _firstname;
                else
                    throw new Exception();

            }
            set
            {
                _firstname = value;
            }
        }
        string _lastname;
        public string LastName
        {
            get
            {
                if (_lastname != null && _lastname.Length < 256)
                    return _lastname;
                else
                    throw new Exception();

            }
            set
            {
                _lastname = value;
            }
        }

    }

}
