using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Атвор: {author}");
        }

      
    }
}