namespace Puzzles
{
    internal class Exercise3_3
    {
        /*
            3-3 Write a bool function that is passed an array and the number of elements in
            that array and determines whether the data in the array is sorted. This should
            require only one pass!         
         */
        public static void Run()
        {
            var numbers = new int[] { 1, 7, 15, 20, 30 };
            Console.WriteLine(IsSorted(numbers));
        }

        private static bool IsSorted(int[] numbers)
        {
            for (var index = 1; index < numbers.Length; index++)
            {
                var lastNumber = numbers[index - 1];
                var number = numbers[index];
                if (number < lastNumber) return false;
            }
            return true;
        }

        private static bool IsSorted2(int[] numbers)
        {
            var lastNumber = 0;
            foreach (var number in numbers)
            {
                if (number < lastNumber) return false;
                lastNumber = number;
            }
            return true;
        }
    }
}
