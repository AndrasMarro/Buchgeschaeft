using System;
using System.Collections.Generic;
using System.Text;

namespace Buchgeschäft
{
    class Item
    {
        public decimal Price;
        public int Stock;
        public string Title { get; }

        public Item(decimal price, int stock, string title)
        {
            Title = title;
            Price = price;
            Stock = stock;
        }
        public bool TryPurchase(int number)
        {
            Stock += number;
            return true;
        }
        public bool TrySell(int number)
        {
            if (number > Stock)
            {
                return false;
            }
            else if (number <= Stock)
            {
                Stock -= number;
                return true;
            }
            else
                return false;
        }
    }
}
