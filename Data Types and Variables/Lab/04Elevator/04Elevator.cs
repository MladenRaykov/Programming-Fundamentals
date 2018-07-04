using System;

namespace _04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)(people) / capacity); // курсовете винаги са цяло число, но при делението може да има загуби, затова каствам едната променлива към double
            Console.WriteLine(courses);

            //Console.WriteLine(Math.Ceiling(1.0 * people / capacity); за предпочитане е този вариант, защото кастването е много "скъпо"
        }
    }
}
