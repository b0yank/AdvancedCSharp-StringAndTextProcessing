namespace _02.StringLength
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new char[20];

            for (int i = 0; i < result.Length; i++)
            {
                if (i < input.Length)
                {
                    result[i] = input[i];
                    continue;
                }

                result[i] = '*';
            }

            Console.WriteLine(result);
        }
    }
}
