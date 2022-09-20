using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    internal class Exercise2_1
    {
        /*
            2-1 Write a program that produces the following shape:
            ########
             ######
              ####
               ##         
         */

        public static void Run()
        {
            for (var rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                var spaceCount = rowIndex;
                for (var colIndex = 0; colIndex < spaceCount; colIndex++)
                {
                    Console.Write(" ");
                }

                var hashTagCount = 8 - rowIndex * 2;
                for (var colIndex = 0; colIndex < hashTagCount; colIndex++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        /*
        public static void Run()
        {
            var hashTagCount = 8;
            for (int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                for (int colIndex = 0; colIndex < hashTagCount; colIndex++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                hashTagCount -= 2;
            }
        }         
         */
    }
}
