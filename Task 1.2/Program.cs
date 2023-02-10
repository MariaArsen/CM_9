using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
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
                byte c = Convert.ToByte(Console.ReadLine());
                double s = 0;
            }
             catch (ArgumentOutOfRangeException) when (c >= 5)
            {
                Console.WriteLine("Нет операции с указанным номером");
            }
}
