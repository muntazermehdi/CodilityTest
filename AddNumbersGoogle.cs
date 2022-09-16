using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class AddNumbersGoogle
    {
        public static bool checkSumAvailble(int X, int[] numberArray)
        {
            
            int sum = numberArray.Sum();

            for (int i = 0; i < numberArray.Length; i++)
            {
                sum = sum - numberArray[i];
            }

            return false;
        }



        public static void Process()
        {
            int X = 8;
            int[] inputArray = new int[] { 1, 2, 4, 4};

            
            bool result;

            result = checkSumAvailble(X, inputArray);
            Console.WriteLine("Result:" + result);
        }
    }
}
