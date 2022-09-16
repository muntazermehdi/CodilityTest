using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class BinaryGap
    {

        public static int findBinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);

            char first = ' ', last = ' ';
            int gap = 0, maxgap = 0;
         
            var lstGap = new List<int>();

            foreach (char chr in binary)
            {
                if (chr == '1' && first == ' ')
                {
                    first = chr;
                }
                else if (chr == '1' && first != ' ')
                {
                    last = chr;
                    if (gap > 0)
                    {
                        lstGap.Add(gap);
                        gap = 0;
                    }
                    last = ' ';
                }
                else if (first == '1' && last != '1')
                {
                    gap += 1;
                }
            }

            if (lstGap.Count == 0)
                maxgap = 0;
            else
            {
                if (lstGap.Max() > 0)
                    maxgap = lstGap.Max();
                else
                    maxgap = 0;
            }

            return maxgap;
        }

    }
}
