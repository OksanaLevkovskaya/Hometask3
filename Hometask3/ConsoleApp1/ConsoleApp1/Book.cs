using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bookitem
    {

        public string nameBook;
        public int datePublished;
        public string nameAuthor;

        public Bookitem(string bName, int dPublished, string aName)
        {
            nameBook = bName;
            datePublished = dPublished;
            nameAuthor = aName;

        }

       
    }
}


