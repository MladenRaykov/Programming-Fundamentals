using System;

namespace _13DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            int newLetter = 0;
            string message = "";

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                newLetter = (int)(letter) + key;
                message += (char)newLetter; 

            }
            Console.Write(message);
        }
    }
}
