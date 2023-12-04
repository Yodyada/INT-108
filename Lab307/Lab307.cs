using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab307
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            Console.Write("Input product id    : ");
            string id = Console.ReadLine();
            Console.Write("Input product unit  : ");
            int unit = int.Parse(Console.ReadLine());
            Console.Write("Input product price : ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Product ID       {0}", id);
            Console.WriteLine("Product Unit\t {0}", unit);
            Console.WriteLine("Product Price\t {0:n}", price);
            Console.WriteLine("-------------------------------------------");
            float total_price1 = unit * price;
            Console.WriteLine("Total Price\t {0:n}", total_price1);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("How many discount(%) in your coupon");
            Console.Write("[if not have coupon, input zero]: ");
            float coupon = float.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            float discount = total_price1 * coupon / 100;
            Console.WriteLine("Discount {0}%\t{1:n}", coupon, discount);
            float total_price2 = total_price1 - discount;
            Console.WriteLine("Total Price\t{0:n}", total_price2);
            Console.ReadKey();
        }
    }
}
