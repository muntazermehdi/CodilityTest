using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class TapeEquilibrium
    {

        public static int findMinimalDifferenceOptimal(int[] numberArray)
        {
            int minDifference = int.MaxValue;

            int  numbersOnRight = 0, numbersOnLeft = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                numbersOnRight += numberArray[i];
            }

            for (int i = 0; i < numberArray.Length -1; i++)
            {
                numbersOnRight -= numberArray[i];
                numbersOnLeft += numberArray[i];

                if (Math.Abs(numbersOnLeft - numbersOnRight) < minDifference)
                    minDifference = Math.Abs(numbersOnLeft - numbersOnRight);
            }

            return minDifference;
        }

        public static int findMinimalDifference(int[] numberArray)
        {
            int minDifference = 0;
            var lstDifference = new List<int>();

            int P = 1, leftSum = 0, rightSum = 0;


            for(int i=0;  i < numberArray.Length -1; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    leftSum += numberArray[j];
                }

                for (int k = P; k < numberArray.Length; k++)
                {
                    rightSum += numberArray[k];
                }

                if(leftSum > rightSum)
                    lstDifference.Add(leftSum  - rightSum);
                else
                    lstDifference.Add(rightSum - leftSum);
                leftSum = 0;
                rightSum = 0;
                P++;
            }

            if (lstDifference.Count == 0)
                minDifference = 0;
            else
            {
                if (lstDifference.Min() > 0)
                    minDifference = lstDifference.Min();
                else
                    minDifference = 0;
            }

            return minDifference;
        }

        public static void Process()
        {
           
            int[] inputArray = new int[] { 3, 1, 2, 4, 3 };

            int result = 0;

            result = findMinimalDifferenceOptimal(inputArray);
            Console.WriteLine("Result:" + result);
        }
    }
}
