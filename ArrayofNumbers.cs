using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfCSharp
{
    class ArrayofNumbers
    {
        int[] array = { 20, 56, 90, 32, 43, 89, 112 };

        public void Do()
        {
            //cant traverse in reverse order

            //foreach (datatype item in array)
               foreach(int num in array)
            {
                Console.WriteLine(num);
                Console.WriteLine(" ");
            }
        }
    }
}
