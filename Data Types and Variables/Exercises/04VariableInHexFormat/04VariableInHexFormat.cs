using System;

namespace _04VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = Convert.ToInt32(text, 16);
            Console.WriteLine(num);
        }
    }
}
