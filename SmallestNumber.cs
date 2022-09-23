using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class SmallestNumber
    {
        public static int findSmallestNumber(int[] numberArray)
        {
            int missingNumber = 1;

            HashSet<int> hsetNumber = new HashSet<int>();

            for (int i = 1; i <= numberArray.Length + 1; i++)
            {
                hsetNumber.Add(i);
            }

            foreach (var number in numberArray)
            {
                hsetNumber.Remove(number);
            }

            missingNumber = hsetNumber.FirstOrDefault();


            return missingNumber;
        }



        public static void Process()
        {
            
            //int[] inputArray = new int[] { 1, 3, 6, 4, 1, 2};

            //int[] inputArray = new int[] { 1, 2, 3};
            int[] inputArray = new int[] { -1, -3};

            //int X = 6;
            //int[] inputArray = new int[] { 1, 3, 1, 6, 2, 3, 4 };

            int result = 0;

            result = findSmallestNumber(inputArray);
            Console.WriteLine("Result:" + result);
        }
    }
}
