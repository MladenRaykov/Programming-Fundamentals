using System;

namespace _06StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
			string helloWorldStr = (string)helloWorld; // Convert.ToString(helloWord)

            Console.WriteLine(helloWorldStr);
        }
    }
}
