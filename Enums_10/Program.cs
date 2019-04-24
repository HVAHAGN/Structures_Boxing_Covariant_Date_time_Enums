using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_10
{
    class Program
    {
        // Сравнение элементов перечисления

        static void Main()
        {
            EnumType x = EnumType.Five;
            EnumType y = EnumType.One;

            //if (x < y)                      // Первый вариант сравнения.
            if (EnumType.Five < EnumType.One) // Второй вариант сравнения.
                Console.WriteLine("X = {0} (меньше чем) Y = {1}.", x, y);
            else
                Console.WriteLine("Y = {0} (меньше чем) X = {1}.", y, x);

            // Delay.
            Console.ReadKey();
        }
    }
}
