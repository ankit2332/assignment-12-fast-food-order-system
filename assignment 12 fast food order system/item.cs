using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_12_fast_food_order_system
{
    class item
    {
        private string name;
        private double price;
        private string id;

        public item(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        
        public string getitemname()
        {
            return name;
        }
        public double getprice()
        {
            return price;
        }

    }
}
