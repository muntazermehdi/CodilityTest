using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class BinaryGapShahzad
    {
        public static int BinaryGap(int A)
        {
            int maxGap = 0, currentGap = 0, index = 0;
            string binaryNumber = Convert.ToString(A, 2);
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '1')
                {
                    int x = index;
                    while (binaryNumber[x] == '0')
                    {
                        currentGap++;
                        x++;
                    }
                    index = i + 1;
                    if (currentGap > maxGap)
                        maxGap = currentGap;
                    currentGap = 0;
                }
            }
            return maxGap;



        }
    }
}
