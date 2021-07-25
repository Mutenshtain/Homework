using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSEN2
{
    class Program
    {
        static void Main(string[] args)
        {

            double Maxtemp, MinTemp;

            Console.WriteLine ("введите максимальную суточную температуру");

            Maxtemp = double.Parse(Console.ReadLine());

            Console.WriteLine ("введите минимальную суточную температуру");

            MinTemp = double.Parse(Console.ReadLine());

            double result = (Maxtemp + MinTemp) / 2;

            Console.WriteLine("среднесуточая температура = " + result);
            
            Console.ReadKey();
        }
    }
}
