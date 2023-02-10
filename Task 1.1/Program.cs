using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции, где 1 - сложение, 2- вычитание, 3-умножение,4-деление");
                char c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Ваш выбор - {0}", c);
                double s;
                switch (c)
                {
                    case '1':
                        Console.WriteLine("Ваш ответ = {0}", s = a + b);
                        break;
                    case '2':
                        Console.WriteLine("Ваш ответ = {0}", s = a - b);
                        break;
                    case '3':
                        Console.WriteLine("Ваш ответ = {0}", s = a * b);
                        break;
                    case '4':
                        if (b==0)
                        Console.WriteLine("Ошибка, деление на ноль");
                        else
                        Console.WriteLine("Ваш ответ = {0}", s = a / b);
                        break;
                    default:
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
