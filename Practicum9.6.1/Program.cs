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
            Exception[] exceptions =
            {
                new DivideByZeroException(),
                new IndexOutOfRangeException(),
                new FormatException(),
                new MyException("Это мое собственное исключение"),
                new NullReferenceException()
            };
            try
            {
                foreach(var exception in exceptions)
                {
                    throw exception;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Возникло исключение" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен.");
            }
            Console.ReadKey();
        }

    }
}
