using System;

namespace _15BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool isBalanced = false;
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(" && counter1 - counter2 == 0)
                {
                    counter1++;
                    isBalanced = true;
                }
                else if (input == "(" && counter1 - counter2 != 0)
                {
                    counter1++;
                    isBalanced = false;
                    break;
                }
                else if (input == ")" && counter1 - counter2 != 1)
                {
                    counter2++;
                    isBalanced = false;
                    break;
                }
                else if (input == ")" && counter1 - counter2 == 1)
                {
                    isBalanced = true;
                    counter2++;
                }
            }
            if (counter1 == counter2)
            {
                isBalanced = true;
            }
            else
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}