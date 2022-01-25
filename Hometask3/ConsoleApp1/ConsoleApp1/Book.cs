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
                return _namebook;
            }
            set
            {
                if (value != null && value.Length <= 256)
                    _namebook = value;
                else
                    throw new Exception("BookName Field is invalid");
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


