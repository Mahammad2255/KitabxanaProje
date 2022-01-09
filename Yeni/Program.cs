using System;
using System.Collections.Generic;

namespace Yeni
{
    class Program
    {
        static void Main(string[] args)
        {

            Library lib1 = new Library();
            lib1.BookList.Add(new Book( "Harry Potter ve olum yadigari", "Roulinq", 860 ));
            lib1.BookList.Add(new Book( "Susa bilmirem", "Lev Tolstoy", 350 ));
            lib1.BookList.Add(new Book( "Bakidan gelen xefiyye", "Elxan Elatli", 250 ));
            lib1.BookList.Add(new Book("Dune", "Frank Herbert", 451 ));
            lib1.BookList.Add(new Book("Etiraf", "Lev Tolstoy", 145 ));
            lib1.BookList.Add(new Book( "Mehkeme", "Frans Kafka", 178 ));
            lib1.BookList.Add(new Book("Lolita", "Vladimir Nabokov", 211 ));
            lib1.BookList.Add(new Book("Ceyn Eyr", "Sarlotta Bronte", 129 ));



            Console.WriteLine("----------------------Butun kitablar----------------------");
            foreach (var item in lib1.BookList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Silinen kitab--- BA3");

            lib1.RemoveByNo("ba3");
            Console.WriteLine("-----------------------------------------------------------");

            foreach (var item in lib1.BookList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Axtarilan kitab --- Lolita");

            foreach (var book in lib1.FindAllBooksByName("Lolita"))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Adi ve ya Muellifi axtarilan kitablar(axtaris edilen --- Lev Tolstoy)");

            foreach (var book in lib1.SearchBooks("Lev Tolstoy"))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Sehife araligina gore kitab axtarisi(daxil edilen--- 50-150");
            foreach (var book in lib1.FindAllBooksByPageCountRange(50, 150))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Kitab adina gore silme silinen kitab --- Ceyn Eyr");
            lib1.RemoveAllBookByName("Ceyn Eyr");

            foreach (var book in lib1.BookList)
            {
                Console.WriteLine(book);
            }
            









          


        }


    }
   
}

