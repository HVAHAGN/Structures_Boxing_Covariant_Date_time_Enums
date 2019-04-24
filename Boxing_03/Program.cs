using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_03
{
    //Упаковка и распаковка

    struct MyStruct //: ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct my = new MyStruct();

            // Упаковка (Boxing).
            ValueType boxed = my;

            // Распаковка объекта (UnBoxing).
            MyStruct unBoxed = (MyStruct)boxed;

            // Delay.
            Console.ReadKey();
        }
    }
}
