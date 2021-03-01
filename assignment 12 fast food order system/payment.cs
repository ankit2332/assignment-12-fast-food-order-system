using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_12_fast_food_order_system
{
    class payment
    {
        private fooditem[] fooditems = new fooditem[0];
        private Drinkitem[] drinkitems = new Drinkitem[0];
        private int foodcount = 0;
        private int drinkcount = 0;
        public payment()
        {
        }

        public void addfood(fooditem food)
        {
            fooditems[foodcount] = food;
            foodcount++;
        }
        public void adddrink(Drinkitem drink)
        {
            drinkitems[drinkcount] = drink;
            drinkcount++;
        }

        public fooditem getfood(int i)
        {
            return fooditems[i];
        }

        public Drinkitem getdrink(int i)
        {
            return drinkitems[i];
        }
        public double findprice(item[] pricelist, string code)
        {
            
            for (int i = 0; i < pricelist.Length; i++)
            {
                if (pricelist[i] != null)
                {
                    pricelist[i].getprice();
                }
            }
            return 0;
        }

        public double calbill(item[] pricelist)
        {
            double total = 0;
            string code = "";
            int quantity = 0;
            double price = 0;
            for (int i = 0; i < drinkitems.Length; i++)
            {
                if(drinkitems[i] != null)
                {
                    code = drinkitems[i].getdrinkid();
                    price = findprice(pricelist, code);
                    quantity = drinkitems[i].getquantity();
                    total += price * quantity;
                }
                if (fooditems[i] != null)
                {
                    code = fooditems[i].getfoodid();
                    price = findprice(pricelist, code);
                    quantity = fooditems[i].getquantity();
                    total += price * quantity;
                }
            }
            return total;

        }
    }

   
}
