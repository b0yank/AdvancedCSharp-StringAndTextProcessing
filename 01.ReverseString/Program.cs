using System;

namespace _01.ReverseString
{
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var reversed = input.ToCharArray().Reverse().ToArray();

            Console.WriteLine(reversed);
        }
    }
}
