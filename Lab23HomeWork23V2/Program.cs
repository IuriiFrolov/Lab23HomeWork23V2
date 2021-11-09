using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWork23
{ // Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода. (вызвать метод из Main)

    class Program
    {
        static ulong Method4(ulong n)
        {
            Console.WriteLine("Method4 начал работу");
            ulong r = 1;
            for (ulong i = 2; i <= n; i++)
            {
                r *= i;
            }

            Console.WriteLine("Method4 окончил работу");

            return (r);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число ОТ 2 до 20: ");
            ulong a = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine();

            ulong factorial = Method4Async(a).Result;
            Console.WriteLine();

            Console.WriteLine("Факториал числа = {0}", factorial);
            Console.WriteLine();

            Console.WriteLine("Main окончил работу");
            Console.ReadKey();
        }
        static async Task<ulong> Method4Async(ulong n)
        {
            Console.WriteLine("Method4Async начал работу");
            ulong result = await Task.Run(() => Method4(n));
            Console.WriteLine("Method4Async окончил работу");
            return result;
        }
    }
}
