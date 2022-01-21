using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace TestingBookFields
{
    [TestClass]
    public class FirstNameTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception), "FirstName Field is invalid")]
        public void NullFirstName()
        {
            Author author = new Author();
            bool actualresult = author.FirstName == null;

        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "FirstName Field is invalid")]
        public void SymbolsAccessLimit()
        {
            Author author = new Author();
            bool actualresult = author.FirstName.Length > 256;
        }

        public class LastNameTests
        {
            [TestMethod]
            [ExpectedException(typeof(System.Exception), "Field is invalid")]
            public void NullLastName()
            {
                Author author = new Author();
                bool actualresult = author.LastName == null;

            }

            [TestMethod]
            [ExpectedException(typeof(System.Exception), "Field is invalid")]
            public void SymbolsAccessLimit()
            {
                Author author = new Author();
                bool actualresult = author.LastName.Length > 256;
            }

            public class BookNameTests
            {
                [TestMethod]
                [ExpectedException(typeof(System.Exception), "Field is invalid")]
                public void NullBookName()
                {
                    Bookitem bookitem = new Bookitem();
                    Bookitem ()
                    bool actualresult = bookitem.NameBook == null;

                }

                [TestMethod]
                [ExpectedException(typeof(System.Exception), "Field is invalid")]
                public void SymbolsAccessLimit()
                {
                    Bookitem bookitem = new Bookitem();
                    bool actualresult = bookitem.NameBook.Length > 256;
                }

            }
        }
    }
}