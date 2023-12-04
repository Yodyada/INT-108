using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab304
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            const int price = 359;
            Console.Write("Input number of customer: ");
            int number_cus = int.Parse(Console.ReadLine());
            int total = number_cus * price;
            Console.WriteLine("Total Price\t{0:n}",total);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Input charge of food leftover (%)");
            Console.Write("[if ont, input zero]: ");
            float leftover = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            float total_price = total + (float)(total*leftover / 100);
            Console.WriteLine("Total Price\t{0:n}", total_price);
            Console.ReadKey();
        }
    }
}
