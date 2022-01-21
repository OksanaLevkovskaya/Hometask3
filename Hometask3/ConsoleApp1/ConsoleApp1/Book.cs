using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bookitem : Author
    {
        string _namebook;

        public string NameBook

        {
            get
            {
                if (_namebook != null && _namebook.Length <= 256)
                    return _namebook;
                else
                    throw new Exception("NameBook Field is invalid");
            }
            set
            {
                _namebook = value;
            }
        }

        public int datePublished;
      

        public Bookitem (string bName, int dPublished, string fName, string lName)
        {
            NameBook = bName;
            datePublished = dPublished;
            FirstName = fName;
            LastName = lName;
            
        }

      
        
    }
}


