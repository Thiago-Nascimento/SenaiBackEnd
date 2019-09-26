using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For each\n");

            string[] v1 = {"a", "b", "c"};

            foreach (string letra in v1)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
