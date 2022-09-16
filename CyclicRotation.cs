using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class CyclicRotation
    {

        public static int[] RotateArray(int[] A, int K) 
        {
            int[] result = new int[A.Length];

            if (A.Length > 0) 
            {
                if (K == 0)
                {
                    result = A;
                }
                else
                { 
                    for (int count = 0; count < K; count++)
                    {
                        result[0] = A[A.Length - 1];

                        for (int i = 0; i < A.Length - 1; i++)
                        {
                            result[i + 1] = A[i];
                        }

                        result.CopyTo(A, 0);
                    }
                }
            }

            return result;
        }

        public static void Process() 
        {
            //int[] inputArray = new int[] { -4 };
            int K = 0;
            int[] inputArray = new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1 , 2 , 3 , 4, 5, 6,7 , 8, 9, 10  };

            int[] outputArray = new int[inputArray.Length];

            outputArray = RotateArray(inputArray, K);
            Console.WriteLine("Result:" + string.Join(", ", outputArray));
        }
    }
}
