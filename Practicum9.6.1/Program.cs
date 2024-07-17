using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum9._6._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Sort sort = new Sort();
            List<string> names = new List<string> { "Иванов", "Петров", "Сидоров", "Кузнецов", "Попов" };

            // Подписка на событие сортировки
            sort.SortNames += Sort.SortName;

            try
            {
                while (true)
                {
                    Console.WriteLine("Введите 1 для сортировки А-Я или 2 для сортировки Я-А:");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        // Вызов события сортировки
                        sort.OnSortNames(names, choice == 1);

                        Console.WriteLine("Отсортированный список фамилий:");
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                    }
                    else
                    {
                        throw new MyException("Неверный ввод. Введите 1 или 2.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода. Введите число 1 или 2.");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
