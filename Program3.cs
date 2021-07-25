using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущщего месяца");

            int Mon;

            Mon = int.Parse(Console.ReadLine());

            string MonTitle = "";


            switch (Mon)
            {
                case 1:
                    MonTitle = "Январь";
                    break;
                case 2:
                    MonTitle = "Февраль";
                    break;
                case 3:
                    MonTitle = "Март";
                    break;
                case 4:
                    MonTitle = "Апрель";
                    break;
                case 5:
                    MonTitle = "Май";
                    break;
                case 6:
                    MonTitle = "Июнь";
                    break;
                case 7:
                    MonTitle = "Июль";
                    break;
                case 8:
                    MonTitle = "Август";
                    break;
                case 9:
                    MonTitle = "Сентябрь";
                    break;
                case 10:
                    MonTitle = "Октябрь";
                    break;
                case 11:
                    MonTitle = "Ноябрь";
                    break;
                case 12:
                    MonTitle = "Декабрь";
                    break;
            }

            Console.WriteLine(MonTitle);

        }
    }
}
