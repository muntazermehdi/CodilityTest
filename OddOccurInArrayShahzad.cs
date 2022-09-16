using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class OddOccurInArrayShahzad
    {
        public static int findOddOneOut(int[] numberArray)
        {

            if (numberArray.Length > 1)
            {
                int xor = numberArray[0];
                for (var i = 1; i < numberArray.Length; i++)
                {
                    xor = xor ^ numberArray[i];
                }
                return xor;
            }
            else
            {
                return numberArray[0];
            }
        }

        public static void Process()
        {
            //int[] inputArray = new int[201];
            //int[] inputArray = new int[] { 999999, 999999, 999999 , 700, 999999 };
            //int[] inputArray = new int[] { 700 };

            int[] inputArray = new int[] { 9, 3, 9, 3, 9, 7, 9 };

            //inputArray[0] = 42;

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    if (i % 2 != 0)
            //        inputArray[i] = 23;
            //    else
            //        inputArray[i] = 70;
            //}

            int result = 0;

            result = findOddOneOut(inputArray);
            Console.WriteLine("Result:" + result);
        }
    }
}
