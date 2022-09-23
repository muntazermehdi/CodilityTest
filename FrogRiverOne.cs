using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class FrogRiverOne
    {
        public static int findEarliestTime(int X, int[] numberArray)
        {
            int earliestTime = 0;

            for (int i = 1; i <= X; i++)
            {
                if (numberArray.Contains(i) == false)
                {
                    earliestTime = -1;
                    break;
                }
                else if (i == X) 
                {
                 earliestTime  =  numberArray.findIndex(i);
                }
                
            }

            return earliestTime;
        }

     

        public static void Process()
        {
            int X = 5;
            int[] inputArray = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            //int X = 2;
            //int[] inputArray = new int[] { 2, 2, 2, 2, 2 };

            //int X = 6;
            //int[] inputArray = new int[] { 1, 3, 1, 6, 2, 3, 4 };

            int result = 0;

            //result = findEarliestTime(X, inputArray);
            result = solutionFrogRiverShahzad(X, inputArray);
            Console.WriteLine("Result:" + result);
        }

        public static int solutionFrogRiverShahzad(int X, int[] A)
        {
            HashSet<int> nums = new HashSet<int>();
            for (int i = 1; i <= X; i++)
            {
                nums.Add(i);
            }

            for (int i = 0; i < A.Length; i++)
            {

                if (nums.Remove(A[i]))
                {
                    if (nums.Count == 0)
                    {
                        return i;
                    }
                }

            }

            return -1;
        }
    }

    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.FindIndex(array, val => val.Equals(item));
        }
    }
}
