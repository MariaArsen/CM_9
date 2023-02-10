using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_9
{
    class Program
    {
        static void Main(string[] args)
        {
          try {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции, где 1 - сложение, 2- вычитание, 3-умножение,4-деление");
                byte c = Convert.ToByte(Console.ReadLine());
                double s = 0;
                if (c == 1)
                {
                    s = a + b;
                }
                else if (c == 2)
                {
                    s = a - b;
                }
                else if (c == 3)
                {
                    s = a * b;
                }
                else if (c == 4 && b != 0)
                {
                    s = a / b;
                }
                else if ((c==0)&&(c >= 5))
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
                else if (b == 0)
                {
                    Console.WriteLine("Ошибка! Деление на ноль!");
                }
                 Console.WriteLine("Ваш выбор - {0}",c);
                 Console.WriteLine("Ваш ответ = {0}",s); 
              }
              catch (DivideByZeroException) 
              {
                Console.WriteLine("Деление на ноль!");
              }
               catch (Exception ex)
              {
                Console.WriteLine(ex.Message);
              }
                Console.ReadKey();
        }
    }
}
