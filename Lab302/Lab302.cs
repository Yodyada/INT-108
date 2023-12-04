using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab302
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            Console.Write("Input student id: ");
            string id = Console.ReadLine();
            Console.Write("Input student name: ");
            string name = Console.ReadLine();
            Console.Write("Input mid-term score: ");
            float mid = float.Parse(Console.ReadLine());
            Console.Write("Input final    score: ");
            float final = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Student name\t: {0} ({1})",name,id);
            float total = mid + final;
            Console.WriteLine("Total score\t: {0} ({1} + {2})",total,mid,final);
            Console.ReadKey();
        }
    }
}
