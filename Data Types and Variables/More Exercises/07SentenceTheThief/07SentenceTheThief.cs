using System;

namespace _07SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            int counts = int.Parse(Console.ReadLine());
            long idMaxValue = long.MinValue;
            double years = 0;

            for (int i = 0; i < counts; i++)
            {
                if (idType == "sbyte")
                {
                    try
                    {
                        sbyte id = sbyte.Parse(Console.ReadLine());
                        if (id > idMaxValue)
                        {
                            idMaxValue = id;
                        }
                    }
                    catch
                    {

                    }
                }
                else if (idType == "int")
                {
                    try
                    {
                        int id = int.Parse(Console.ReadLine());
                        if (id > idMaxValue)
                        {
                            idMaxValue = id;
                        }
                    }
                    catch
                    {

                    }

                }
                else if (idType == "long")
                {
                    try
                    {
                        long id = long.Parse(Console.ReadLine());
                        if (id > idMaxValue)
                        {
                            idMaxValue = id;
                        }
                    }
                    catch
                    {

                    }

                }
            }
             if (idMaxValue > 0)
            {
                years = 1.0 * idMaxValue / 127;
            }
            else
            {
                years = Math.Abs(1.0 * idMaxValue / 128);
            }
            if (years > 1)
            {
                Console.WriteLine($"Prisoner with id {idMaxValue} is sentenced to {Math.Ceiling(years)} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {idMaxValue} is sentenced to {Math.Ceiling(years)} year");
            }
        }
    }
}
