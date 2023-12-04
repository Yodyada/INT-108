using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab306
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            const int price_nood_s = 15, price_nood_l = 30, price_chicken_skin = 10;
            Console.Write("Input number of noodle (S): ");
            int nood_s = int.Parse(Console.ReadLine());
            Console.Write("Input number of noodle (L): ");
            int nood_l = int.Parse(Console.ReadLine());
            Console.Write("Input number of crispy chicken skin: ");
            int chicken_skin = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int total_nood_s = price_nood_s * nood_s;
            Console.WriteLine("Price of noodle (S)\t\t{0:n} baht.", total_nood_s);
            int total_nood_l = price_nood_l * nood_l;
            Console.WriteLine("Price of noodle (L)\t\t{0:n} baht.", total_nood_l);
            int total_chicken_skin = price_chicken_skin * chicken_skin;
            Console.WriteLine("Price of crispy chicken skin\t{0:n} baht.", total_chicken_skin);
            Console.WriteLine("--------------------------------------------------");
            int all_total = total_nood_s + total_nood_l + total_chicken_skin;
            Console.Write("Total price {0:n} baht.", all_total);
            Console.ReadKey();
        }
    }
}
