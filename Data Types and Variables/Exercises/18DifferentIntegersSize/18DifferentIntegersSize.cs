using System;

namespace _18DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            
			string num = Console.ReadLine();
            try
            {
                long output = long.Parse(num);
                Console.WriteLine($"{num} can fit in:");
                if (sbyte.TryParse(num, out sbyte resultSbyte))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(num, out byte resultByte))
                {
                    Console.WriteLine($"* byte");
                }
                if (short.TryParse(num, out short resultShort))
                {
                    Console.WriteLine($"* short");
                }
                if (ushort.TryParse(num, out ushort resultUshort))
                {
                    Console.WriteLine($"* ushort");
                }
                if (int.TryParse(num, out int resultInt))
                {
                    Console.WriteLine($"* int");
                }
                if (uint.TryParse(num, out uint resultUint))
                {
                    Console.WriteLine($"* uint");
                }
                Console.WriteLine($"* long");
            }
            catch
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
        }
    }
}
