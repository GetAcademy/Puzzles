namespace Puzzles
{
    internal class Exercise2_9
    {
        /*
         Pause til 11:08

            2-9 Write a program that reads a line of text
             - counting the number of words
             - identifying the length of the longest word
                   _  _   _
                 0123456789
                "en to tre fire"
             - the greatest number of vowels in a word
             - any other statistics you can think of         
         */
        public static void Run()
        {
            var text = Console.ReadLine();
            var index = 0;
            var spaceCount = 0;
            var maxLength = 0;
            var maxVowelCount = 0;
            var wordWithMaxVowelCount = "";
            while (true)
            {
                var newIndex = text.IndexOf(' ', index);

                var endIndex = newIndex == -1 ? text.Length : newIndex;
                var length = endIndex - index;
                if (length > maxLength) maxLength = length;

                var word = text.Substring(index, length);
                var vowelCount = CountVowels(word);
                if (vowelCount > maxVowelCount)
                {
                    maxVowelCount = vowelCount;
                    wordWithMaxVowelCount = word;
                }

                if (newIndex == -1) break;

                index = newIndex + 1;
                spaceCount++;
            }

            var wordCount = spaceCount + 1;
            Console.WriteLine($"Antall ord er: {wordCount}");
            Console.WriteLine($"Det lengste ordet er på {maxLength} bokstaver");
            Console.WriteLine($"Ordet {wordWithMaxVowelCount} har flest vokaler - {maxVowelCount} vokaler");
        }

        private static int CountVowels(string word)
        {
            word = word.ToLower();
            const string vowels = "aeiuyoæøå";

            var vowelCount = 0;
            foreach (var c in word)
            {
                var isVowel = vowels.Contains(c);
                if (isVowel)
                {
                    vowelCount++;
                }
            }
            return vowelCount;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    var c = word[i];
            //}
        }

        //public static void Run2()
        //{
        //    var text = Console.ReadLine();
        //    var index = -1;
        //    do
        //    {
        //        index++;
        //        index = text.IndexOf(' ', index);
        //        Console.WriteLine($"Fant mellomrom på indeks {index}");
        //    } while (index != -1);
        //}
    }
}
