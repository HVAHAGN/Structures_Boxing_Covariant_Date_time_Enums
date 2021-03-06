﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_05
{
    class Program
    {
        // Перечисления. Получение информации о типе элементов перечисления
        static void Main()
        {
            EnumType digit = EnumType.Ten;

            // Enum.GetUnderlyingType() - показывает тип, который используется для представления 
            // числовых значений элементов перечисления.
            Type @enum = digit.GetType();
            Console.Write("1. Перечисление {0} состоит из элементов типа: ", @enum.Name);
            Type @const = Enum.GetUnderlyingType(@enum);
            Console.WriteLine(@const);

            // оператор typeof - возвращает экземпляр класса System.Type, который содержит информацию
            // о том типе, который был передан в качестве аргумента данного оператора.

            Console.Write("2. Перечисление EnumType состоит из элементов типа: ");

            Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));

            // Delay.
            Console.ReadKey();
        }
    }
}
