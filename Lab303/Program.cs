using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab303
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            Console.Write("Input rectangle width : ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Input rectangle length : ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            float rec = (float)width * length;
            Console.WriteLine("Rectangle Area => {0} x {1}\t = {2:f1}", width, length,rec);
            float cir = 2 * (float)(width + length);
            Console.WriteLine("Circumference  => 2 x ({0} + {1}) = {2:f1}", width, length,cir);
            Console.ReadKey();
        }
    }
}
