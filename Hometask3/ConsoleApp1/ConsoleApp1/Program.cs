using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class BooksComparer: IComparer<Bookitem>
    {
        public int Compare(Bookitem x, Bookitem y)
        {
           return x.datePublished.CompareTo(y.datePublished);
        }
    }

    public class Book

    {
        public static void Main(string[] args)
        {

            Bookitem book1 = new Bookitem( "White Fang", 1906, "Jack London");
            Bookitem book2 = new Bookitem("Gone With The Wind", 1936, "Margaret Mitchell");
            Bookitem book3 = new Bookitem("Paradise", 1995, "Abdulrazak Gurnah");
            Bookitem book4 = new Bookitem("All About Me!", 2021, "Mel Brooks");
            Bookitem book5 = new Bookitem("Fuzz", 2021, "Mary Roach");
            Bookitem book6 = new Bookitem("Gastro Obscura", 1981, "Cecily Wong");
            Bookitem book7 = new Bookitem("God, Human, Animal, Machine", 1995, "Meghan O'Gieblyn");
            Bookitem book8 = new Bookitem("Atlas of the Heart", 1997, "Ayn Rand");
            Bookitem book9 = new Bookitem("Everyone's Table", 2000, "Gregory Gourdet");
            Bookitem book10 = new Bookitem("Atlas Shrugged", 2016, "Ayn Rand");


            List<Bookitem> bookitemsList = new List<Bookitem>() { book1, book2, book3,book4,book5,book6,
                                                              book7, book8, book9,book10};
            bookitemsList.Sort(new BooksComparer());
            foreach (Bookitem bookitem in bookitemsList)
            Console.WriteLine(bookitem.datePublished);
        }

        
    }
}