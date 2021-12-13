using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число  Х =");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число  У =");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n 1 - сложение \n 2 - вычетание \n 3 - умножение \n 4 - деление");
                Console.WriteLine("Ваш выбор:");
                int cmd = Convert.ToInt32(Console.ReadLine());
                switch (cmd)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат равен = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен = {0:f2}", x / y);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операций с указанным номером!");
                            break;
                        }
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
