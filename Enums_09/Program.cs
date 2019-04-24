using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_09
{
    class Program
    {
        // Получение информации о количестве элементов перечисления. Получение всех элементов перечисления и их значений

        static void Main()
        {
            // Enum.GetValues() - возвращает экземпляр System.Array, при этом каждому элементу массива 
            // будет соответствовать член указанного перечисления.

            // Помещаем в массив элементы перечисления.
            Array array = Enum.GetValues(typeof(EnumType));

            // Получаем информацию о количестве элементов в массиве.
            Console.WriteLine("Это перечисление содержит {0} членов \n", array.Length);

            // Вывод на экран всех элементов перечисления
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Имя константы: {0}, значение {0:D}", array.GetValue(i));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
