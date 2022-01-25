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
            author.FirstName = null;
          
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "FirstName Field is invalid")]
        public void SymbolsAccessLimitFN()
        {
            Author author = new Author();
            author.FirstName = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.  Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. ";
        }


        [TestMethod]
        public void SetFirstNamePositive()
        {
            Author author = new Author();
            author.FirstName = "Jack";

        }
    }

    [TestClass]
    public class LastNameTests
    {
            [TestMethod]
            [ExpectedException(typeof(System.Exception), "Field is invalid")]
            public void NullLastName()
            {
            Author author = new Author();
            author.LastName = null;

            }

        [TestMethod]
            [ExpectedException(typeof(System.Exception), "Field is invalid")]
            public void SymbolsAccessLimitLN()
            {
            Author author = new Author();
            author.LastName = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.  Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. ";
            }

        [TestMethod]
        public void SetLastNamePositive()
        {
            Author author = new Author();
            author.LastName = "London";

        }

    }

    [TestClass]
    public class BookNameTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception), "BookName Field is invalid")]
        public void NullBookName()
        {
            Bookitem bookitem = new Bookitem ("", 1992, "a", "a");
            bookitem.NameBook = null;
          
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "BookName Field is invalid")]
        public void SymbolsAccessLimitBN()
        {
            Bookitem book = new Bookitem("", 1906, "Jack", "London");
            book.NameBook = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.  Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. ";
        }

        [TestMethod]
        public void SetBookNamePositive()
        {
            Bookitem book = new Bookitem("", 1906, "Jack", "London");
            book.NameBook = "Cat";

        }
    }


}