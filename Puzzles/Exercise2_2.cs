namespace Puzzles
{
    internal class Exercise2_2
    {
        /*

        Pause til 10:30

            2-2 Or how about:
               ##
              ####
             ######
            ########
            ########
             ######
              ####
               ##            
         */
        public static void Run()
        {
            for (var rowIndex = 3; rowIndex >= 0; rowIndex--)
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

    }
}
