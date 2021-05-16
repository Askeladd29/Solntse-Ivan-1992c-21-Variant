using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Солнце_Иван_1992с_Вариант_21
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите K");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результат: {Imet.GetScore(k)}");
                Console.ReadKey();
            }
        }
    }
}
