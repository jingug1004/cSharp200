using System;
using HellWorl.s131;

namespace HellWorl
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            C131 instC131 = new C131();
            instC131.PrintPrime(10);
        }
    }
}