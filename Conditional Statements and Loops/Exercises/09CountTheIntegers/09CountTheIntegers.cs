using System;

namespace _09CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
