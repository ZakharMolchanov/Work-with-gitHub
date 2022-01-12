using System;

namespace Work_with_gitHub
{
    class Program
    {
        private static void WriteArray(int[] ints)
        {
            foreach (var integer in ints)
            {
                Console.Write(integer + " ");
            }
            Console.WriteLine();
        }
        // Comment 
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i > 10; i++)
            {
                Console.WriteLine("a" + i);
            }

            var arr = new int[] {1, 2, 3, 4, 5, 6};
            WriteArray(arr);
        }
    }
}
