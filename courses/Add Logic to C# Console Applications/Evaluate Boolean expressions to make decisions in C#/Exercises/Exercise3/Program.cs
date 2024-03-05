// Code challenge: write code to display the result of a coin flip

using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write code to display the result of a coin flip
            Random random = new Random();
            int flip = random.Next(0, 2);
            Console.WriteLine(flip == 0 ? "Heads" : "Tails");
        }
    }
}
