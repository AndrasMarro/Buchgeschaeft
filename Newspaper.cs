using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Newspaper : Item
    {
        public DateTime DateOfIssue;

        public Newspaper(decimal price, int stock, string title, DateTime dateOfIssue) : base(price, stock, title)
        {
            DateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"{Title} ({DateOfIssue.Date}) ";
        }
    }
}