using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_12_fast_food_order_system
{
    class Drinkitem
    {
        private string Drinkname;
        private int quantity;
        private string drinkid;

        public Drinkitem(string Drinkname, int quantity, string drinkid)
        {
            this.Drinkname = Drinkname;
            this.quantity = quantity;
            this.drinkid = drinkid;
            
        }

        public string getdrinkname()
        {
            return Drinkname;
        }

        public int getquantity()
        {
            return quantity;

        }
        public string getdrinkid()
        {
            return drinkid;
        }
    }
}
