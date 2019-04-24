using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant_04
{
    //Ковариантность не применима к массивам элементов структурных типов.
    public interface IAnimal
    {
        void Voice();
    }

    public struct Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Gav-Gav");
        }
    }

    class Program
    {
        static void Main()
        {
            // 1
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            //IAnimal[] animal = dogs; // Ковариантность.
            //dogs = array;  // Контрвариантность.
            ValueType i = new Int32() as ValueType;

            // 2
            int[] vector = new int[3] { 1, 2, 3 };
            //object[] array = vector; // Ковариантность


            // Задержка.
            Console.ReadKey();
        }
    }
}
