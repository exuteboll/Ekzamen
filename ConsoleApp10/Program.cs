using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title("Война и мир");
            Author author = new Author("Лев Толстой");
            Content content = new Content("Роман о жизни и судьбах.");

            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadKey();
        }
    }
}