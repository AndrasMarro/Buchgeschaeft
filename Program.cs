using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(100, 10, "Herr Der Dinge", "Steve Jobless", "1", Category.Fantasy);
            Newspaper n1 = new Newspaper(2.50m, 134, "Tageszeitung", new DateTime(2021, 1, 10));
            AudioBook a1 = new AudioBook(3.40m, 1000000000, "Der Dratseil Bratan", "Philippe Petit", "3", 56, Category.Documentary);

            Console.WriteLine(b1.ToString());
            Console.WriteLine(n1.ToString());
            Console.WriteLine(a1.ToString());
            Console.ReadKey();
        }
    }
}
