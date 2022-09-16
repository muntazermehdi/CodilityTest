using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class PermMissingElement
    {
        public static int findMissingNumber(int[] numberArray)
        {
            int missingNumber = 0;

            HashSet<int> hsetNumber = new HashSet<int>();

            for (int i=1; i <= numberArray.Length + 1; i++)     
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
            //int[] inputArray = new int[] { -4 };
            int K = 0;
            int[] inputArray = new int[] { 2, 3, 1, 5};

            int result = 0;

           result = findMissingNumber(inputArray);
            Console.WriteLine("Result:" + result);
        }
    }
}
