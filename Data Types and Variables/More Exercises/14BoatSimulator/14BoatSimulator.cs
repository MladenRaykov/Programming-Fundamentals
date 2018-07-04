using System;

namespace _14BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            int firstBoatTiles = 0;
            int secondBoatTiles = 0;
            int firstBoatUpgrade = firstBoat;
            int secondBoatUpgrade = secondBoat;

            for (int i = 1; i <= lines; i++)
            {
                string moves = Console.ReadLine();

                if (i % 2 == 0 && moves != "UPGRADE")
                {
                        secondBoatTiles += moves.Length;
                }
                else if (i % 2 != 0 && moves != "UPGRADE")
                {
                        firstBoatTiles += moves.Length;
                }
                if (moves == "UPGRADE")
                {
                    firstBoatUpgrade += 3;
                    secondBoatUpgrade += 3;
                }
                if (firstBoatTiles >= 50)
                {
                    Console.WriteLine((char)firstBoatUpgrade);
                    return;
                }
                else if (secondBoatTiles >= 50)
                {
                    Console.WriteLine((char)secondBoatUpgrade);
                    return;
                }
            }
            if (firstBoatTiles > secondBoatTiles)
            {
                Console.WriteLine((char)firstBoatUpgrade);
            }
            else
            {
                Console.WriteLine((char)secondBoatUpgrade);
            }
        }
    }
}
