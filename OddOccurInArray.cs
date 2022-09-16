using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class OddOccurInArray
    {
        public static int findOddNumber(int[] numberArray) 
        {
            int oddNumber = 0;
            HashSet<int> numHash = new HashSet<int>();
            HashSet<int> duplicateHash = new HashSet<int>();

            if (numberArray.Length > 1)
            {

                foreach (var number in numberArray)
                {
                    if (numHash.Add(number) == false)
                    {
                        duplicateHash.Add(number);
                    }
                }
            }
            else
            {
                oddNumber = numberArray[0];
            }

            var diffHashSet = numHash.Except(duplicateHash);

            if (diffHashSet.Count() > 0)
                oddNumber = diffHashSet.ToList().First();
            else
                oddNumber = numberArray[0];

            return oddNumber;
        }

        public static void Process()
        {
            //int[] inputArray = new int[201];
            //int[] inputArray = new int[] { 999999, 999999, 999999 , 700, 999999 };
            //int[] inputArray = new int[] { 700 };

            int[] inputArray = new int[] { 9, 3, 9, 3, 9, 7, 9 };

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    if (i % 2 != 0)
            //        inputArray[i] = 23;
            //    else
            //        inputArray[i] = 70;
            //}
            //inputArray[inputArray.Length-1] = 70;

            int result = 0;

            result = test(inputArray);
            Console.WriteLine("Result:" + result);
        }

        public static int test(int[] numberArray) 
        {
            int maxValue = -1;
            if (numberArray.Length > 1)
            {
                var query = numberArray.GroupBy(x => x)
                  .Where(g => g.Count() >= 1)
                  .ToDictionary(x => x.Key, y => y.Count());

                if (query.Count() == 3)
                {
                    maxValue = query.Last().Key;
                }
                else
                {
                    maxValue = query.Single(x => x.Value == Math.Max(query.ElementAt(0).Value, query.ElementAt(1).Value)).Key;
                }
            }
            else 
            {
                maxValue = numberArray[0];
            }
            
            return maxValue;
        }

    }
}
