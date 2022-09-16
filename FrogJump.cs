using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaphorSolution
{
    class FrogJump
    {
        public static int countMinimalJumps(int startingPoint, int destinationPoint, int distance) 
        {
            int jumpCount = 0;

            if (startingPoint == destinationPoint)
            {
                jumpCount = 0;
            }
            else
            {
                 jumpCount = Convert.ToInt32(Math.Ceiling((destinationPoint - startingPoint) / (double)distance));
            }

            return jumpCount;
        }

        public static void Process()
        {
            //int X=10, Y=85, D=30;
            int X=1, Y=5, D=2;
            //int X=1, Y=1, D=1;
            int result =0;


            result = countMinimalJumps(X,Y,D);
            Console.WriteLine("Result:" + result);
        }
    }
}
