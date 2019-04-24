using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant_05
{
    // Противоречие между системой типов CLI и системой типов C#. 
    // (ковариантность массивов типов-значений несогласована)
    class Program
    {
        static void Main()
        {
            uint[] array = new uint[3];

            Console.WriteLine("array  {0} {1}", array is uint[], array is int[]);

            object @object = array;

            Console.WriteLine("object {0} {1}", @object is uint[], @object is int[]);

            // Delay.
            Console.ReadKey();
        }
    }
}
