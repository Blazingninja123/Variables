using System;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyVar = 3;
            
            
            Console.WriteLine(-1 + 4 * MyVar);

            Console.WriteLine((35+5) % MyVar);

            Console.WriteLine(14 + -4 * 6 / 12);

            Console.WriteLine(2 + 12 / 6 * 1 - MyVar % 2);

            if (MyVar * MyVar < 10)
            Console.WriteLine("My variable is less than 10 ");

            else
            Console.WriteLine("My variable is greater than 10");

        }
    }
}

