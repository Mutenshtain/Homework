using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string CHEKS = "CHEKS.COM"; 
            double Water = 44.5;
            double Snikers = 55.8;
            double Bread = 44.6;
            double Smoke = 33.3;
            double Summa = (Water + Snikers + Bread + Smoke);
            DateTime date = new DateTime(2015, 3, 4, 16, 23, 42);

            Console.WriteLine(CHEKS);
            Console.WriteLine(date.ToString("dd.MM.yy")); // 04.03.21
            Console.WriteLine(date.ToString("HH:mm:ss")); // 16:23:42
            Console.WriteLine("Вода..................... " + Water);
            Console.WriteLine("Шоколадный батончик...... " + Snikers);
            Console.WriteLine("Хлеб..................... " + Bread);
            Console.WriteLine("Сигареты................. " + Smoke);
            Console.WriteLine("Сумма.................... " + Summa);

        }
    }
}
