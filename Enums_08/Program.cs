using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_08
{
    class Program
    {
        // Поиск элемента перечисления по имени константы.

        static void Main()
        {
            // Находим элемент перечисления по имени константы.
            object element = Enum.Parse(typeof(EnumType), "Infinite");
            EnumType number = (EnumType)element;

            Console.WriteLine("Значение константы {0}: {1}", number, (byte)number);

            // Enum.IsDefined() - Позволяет определить, является ли символьная строка элементом перечисления? 
            bool flag = Enum.IsDefined(typeof(EnumType), "one");

            if (flag == true)
                Console.WriteLine("Да, перечисление содержит элемент с таким именем.");
            else
                Console.WriteLine("Нет, перечисление не содержит элемент с таким именем.");

            // Delay.
            Console.ReadKey();
        }
    }
}
