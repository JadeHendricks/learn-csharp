using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class BookClassParent
    {
        static void Main(string[] args)
        {
            BookClass book1 = new BookClass("Harry Potter", "JK Rowling", 400);
            BookClass book2 = new BookClass("Lord Of The Rings", "Tolkein", 700);
            BookClass book3 = new BookClass();

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.WriteLine(book1.HasMoreThan500Pages());
            Console.WriteLine(book2.HasMoreThan500Pages());
        }
    }
}
