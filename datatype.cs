using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfCSharp
{
    class DataTypes
    {
        public void Do() 
        { 
            //numerical
            //4 byte
            //struct, not a class
            int num1 = 100;
            Console.WriteLine(num1);

            //8byte
            long num2 = 65793489;
            Console.WriteLine(num2);

            //precision based values- 4byte
            float num3 = 100.01F;
            Console.WriteLine(num3);

            //8 byte
            double num4 = 4134345324.89;
            Console.WriteLine(num4);

            //16 byte
            decimal num5 = 423412343556.89M;
            Console.WriteLine(num5);

            //alphanumeric
            char ch = 'c';
            Console.WriteLine(ch);

            //string is class or reference type. its immutable.
            string str = "my name";
            Console.WriteLine(str);

            //boolean values  true,false
            bool isTrue = true;
            Console.WriteLine(isTrue);


        }
    }
}
