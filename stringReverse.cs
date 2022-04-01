using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfCSharp
{
    class stringReverse
    {
        public void reverseString()
        {
            Console.WriteLine("Please Enter a string to reverse");
            string input = Console.ReadLine();

            //string is collection of characters
            //for(initailization; condition; increament/decreament)
            //Mumbai => iabmuM => 6 (0-5)
            //start reading from last index char
            //store/append it in a separate character
            //decreament index position

            string result = string.Empty;
            for(int i= input.Length-1; i>=0; i--)
            {
                result = result + input[i];//i, ia, iab
            }
            Console.WriteLine(result);
        }
    }
}
