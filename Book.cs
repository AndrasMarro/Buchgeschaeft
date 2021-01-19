using System;
using System.Collections.Generic;
using System.Text;

namespace Buchgeschäft
{
    enum Category
    {
        Fantasy = 1, Food = 2, Action = 3, Documentary = 4, History = 5
    }

    class Book : Item
    {
        public string Author;
        public string Isbn;
        protected Category Category;

        public Book(decimal price, int stock, string title, string author, string isbn, Category category):base(price, stock, title)
        {
            Author = author;
            Isbn = isbn;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Title} ({Author} ({Category}))";
        }
    }
}
