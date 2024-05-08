using System;

namespace ConsoleApp
{
    public class Program
    {
        static void CountDown(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine(n);
                CountDown(n -1);
            }
        }
        public static void Main(string[] args)
        {
            CountDown(5);
        }
    }
}