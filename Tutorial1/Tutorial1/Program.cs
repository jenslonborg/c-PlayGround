using System;
using RectangleApplication;
using PerfectSquareApplication;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World
            Console.WriteLine("Hello World!");
            //Basics
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            r.SetDetails(1.1, 3.1);
            r.Display();
            //Some fun
            PerfectSquare perf = new PerfectSquare();
            for (double n = 1; n <= 100000; n++)
            {
                double candidate = n * n + 45;
                if (perf.IsPerfect(candidate))
                {
                    Console.WriteLine("{0} gives a perfect square. It is {1} -> {2}", n, candidate, Math.Sqrt(candidate));
                }
            }
            Console.WriteLine("Found all perfect Squares");
            Console.ReadKey();
        }
    }
}
