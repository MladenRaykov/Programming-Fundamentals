using System;

namespace _06CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int counts = int.Parse(Console.ReadLine());
            long maxValue = long.MinValue;

            for (int i = 1; i <= counts; i++)
            {
                if (type == "sbyte")
                {
                    try
                    {
                        sbyte id = sbyte.Parse(Console.ReadLine());
                        if (id > maxValue)
                        {
                            maxValue = id;
                        }
                    }
                    catch
                    {

                    }
                }
                else if (type == "int")
                {
                    try
                    {
                        int id = int.Parse(Console.ReadLine());
                        if (id > maxValue)
                        {
                            maxValue = id;
                        }
                    }
                    catch 
                    {

                    }

                }
                else if (type == "long")
                {
                    try
                    {
                        long id = long.Parse(Console.ReadLine());
                        if (id > maxValue)
                        {
                            maxValue = id;
                        }
                    }
                    catch
                    {

                    }

                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
