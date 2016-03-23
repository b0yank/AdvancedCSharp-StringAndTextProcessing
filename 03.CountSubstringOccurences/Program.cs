namespace _03.CountSubstringOccurences
{
    using System;

    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var @string = Console.ReadLine().ToLower();

            var occurrenceCount = 0;

            for (int i = 0; i + @string.Length - 1 < text.Length; i++)
            {
                var textSubstring = text.Substring(i, @string.Length);

                if (String.CompareOrdinal(textSubstring, @string) == 0)
                {
                    occurrenceCount++;
                }
            }

            Console.WriteLine(occurrenceCount);
        }
    }
}
