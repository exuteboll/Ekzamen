using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     class Book
    {
        private Title title;
        private Author author;
        private Content content;

      public Book(Title title, Author author, Content content)
        {
            this.author = author;
            this.title = title;
            this.content = content;
        }

        public void Show()
        {
            content.Show();
            title.Show();
            author.Show();
        }
    }
}