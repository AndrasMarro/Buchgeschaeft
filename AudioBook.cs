using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class AudioBook : Book
    {
        public int Duration;

        public AudioBook(decimal price, int stock, string title, string author, string isbn, int duration, Category category) : base(price, stock, title, isbn, author, category)
        {
            Duration = duration;
        }
        public override string ToString()
        {
            return $"{Title} ({Author}, {Duration} minutes ({Category})) ";
        }
    }
}
