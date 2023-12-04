using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab308
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            Console.Write("Input value in A : ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Input value in B : ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Value in variable 'A' is {0}", A);
            Console.WriteLine("Value in variable 'B' is {0}", B);

            //statement to swap value in variables <-- write by yourself

            Console.WriteLine("---------------------------");
            Console.WriteLine("     !! SWAP NUMBER !!     ");
            Console.WriteLine("---------------------------");
            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Value in variable 'A' is {0}", A);
            Console.WriteLine("Value in variable 'B' is {0}", B);

            Console.ReadKey();
        }
    }
}
