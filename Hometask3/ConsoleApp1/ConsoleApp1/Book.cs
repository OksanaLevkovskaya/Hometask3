using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bookitem
    {
        string _namebook;
        
        public string NameBook
            
        {
            get
            {
                if (_namebook != null)
                    return _namebook;
                else
                    throw new Exception();
             
            }
            set
            {
                _namebook = value;
            }
        }

        public int datePublished;

        string _nameauthor;
        public string NameAuthor
        {
            get
            {
                if (_nameauthor != null)
                    return _nameauthor;
                else
                    throw new Exception();

            }
            set
            {
                _nameauthor = value;
            }
        }

        public Bookitem(string bName, int dPublished, string aName)
        {
            NameBook = bName;
            datePublished = dPublished;
            NameAuthor = aName;

        }
        
    }
}


