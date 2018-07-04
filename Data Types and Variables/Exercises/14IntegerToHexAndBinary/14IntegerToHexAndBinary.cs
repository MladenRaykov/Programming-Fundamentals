using System;

namespace _14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(num, 16);
            string hexaUpper = hexadecimal.ToUpper();
            string binary = Convert.ToString(num, 2);

            Console.WriteLine(hexaUpper);
            Console.WriteLine(binary);
        }
    }
}
