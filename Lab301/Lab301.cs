using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode1_01072564
{
    class Program
    {
        //2113110189 ยอดญาดา สุขแสงจันทร์
        static void Main(string[] args)
        {
            Console.Write("Input Number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input Number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sum = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}",num1,num2,sum);
            int sub = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, sub);
            int mul = num1 * num2;
            Console.WriteLine("{0} x {1} = {2}", num1, num2, mul);
            float divis = num1 / (float)num2;
            Console.WriteLine("{0} / {1} = {2:f}", num1, num2, divis);
            int mod = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, mod);
            Console.ReadKey();
        }
    }
}
