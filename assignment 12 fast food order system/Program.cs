using System;
using System.IO;

namespace assignment_12_fast_food_order_system
{
    class Program
    {
        static void Main(string[] args)
        {

            payment ankitluch = new payment();
            item[] items = new item[100];

            StreamReader FileReader = new StreamReader("food.csv");
            string line = FileReader.ReadLine();
            Console.WriteLine(line);
            int count = 0;

            while ((line = FileReader.ReadLine()) != null)
            {
                string[] cell = line.Split(',');
                string code = cell[0];
                string name = cell[1];
                double price = Convert.ToDouble(cell[2]);

                Console.WriteLine("{0} {1} {2} {3}",count, code,name,price);
                count++;
                items[count] = new item(code,name,price);
            }
            makeanorder();

            
            
                
        }
        public static void makeanorder()
        {
            Console.WriteLine("Input the code for the Food or Drink you want:");
            int order = Console.Read();


        }
    }
}
