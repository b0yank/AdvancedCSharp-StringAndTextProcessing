namespace _04.TextFilter
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var banList = Console.ReadLine()
                .Split(new [] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var text = Console.ReadLine();


            foreach (var word in banList)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
