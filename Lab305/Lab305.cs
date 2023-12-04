using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab305
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            const int price_child = 100, price_adult = 250;
            Console.WriteLine("** If not, input zero");
            Console.Write("Input number of child ticket: ");
            int child_ticket = int.Parse(Console.ReadLine());
            Console.Write("Input number of adult ticket: ");
            int adult_ticket = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int total_child = price_child * child_ticket;
            Console.WriteLine("Total price of child ticket {0:n} baht.", total_child);
            int total_adult = price_adult * adult_ticket;
            Console.WriteLine("Total price of adult ticket {0:n} baht.", total_adult);
            Console.WriteLine("---------------------------------------------------");
            int all_total = total_adult + total_child;
            Console.WriteLine("Total price {0:n} baht.", all_total);
            Console.ReadKey();
        }
    }
}
