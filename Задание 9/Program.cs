using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{   //Обработка исключений для калькулятора
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КАЛЬКУЛЯТОР");
            try
            {                
                Console.Write("Введите целое число: Х= ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: Y= ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Виды возможных операций:\n\t1 - сложение\n\t2 - вычитание\n\t3 - произведение\n\t4 - частное\nВведите код операции:");
                byte n = Convert.ToByte(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ваш результат = {0}", x + y);
                        break;
                    case 2:
                        Console.WriteLine("Ваш результат = {0}", x - y);
                        break;
                    case 3:
                        Console.WriteLine("Ваш результат = {0}", x * y);
                        break;
                    case 4:
                        Console.WriteLine("Ваш результат = {0}", x / y);
                        break;
                    default:
                        Console.WriteLine("Выбрана несуществующая операция.");
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
