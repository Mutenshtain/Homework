using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число не четное");
            }





        }
    }
}
