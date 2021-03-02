using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_12_fast_food_order_system
{
    class fooditem
    {
        private string foodname;
        private int quantity;
        private string foodid;

        public fooditem(string foodname, int quantity, string foodid)
        {
            this.foodname = foodname;
            this.quantity = quantity;
            this.foodid = foodid;
        }

        public string getfoodname()
        {
            return foodname;
        }

        public int getquantity()
        {
            return quantity;

        }
        public string getfoodid()
        {
            return foodid;
        }
    }
}

