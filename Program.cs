using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите число. x= ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число. y= ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - частное");
            Console.WriteLine("Ваш выбор: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ответ: ");
            switch (f)
            {
                case 1:
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine(x / y);
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером");
                    break;
            }
            Console.ReadKey();
        }
    }
}
