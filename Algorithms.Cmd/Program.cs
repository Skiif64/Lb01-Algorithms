using System;
using System.Collections.Generic;


namespace Algorithms.Cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new SvenAlgorithm();
            var result = algorithm.GetMaximumExtremumRange(Func, 3, 0.01);
            Console.WriteLine($"[{result.a}; {result.b}]");
        }

        static double Func(double x)
        {
            var r = Math.Pow(x, 2) - x;
            var result = Math.Pow(r, 1.0 / 3.0);
            return result;
        }
    }
}
