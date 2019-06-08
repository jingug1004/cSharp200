using System;
using HellWorl.s131;

namespace HellWorl
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // C132 instC132 = new C132();
            // instC131.PrintPrime(10);

            C132 instC132 = new C132(3);
            instC132.ReMake();
            instC132.PrintErotos();
        }
    }
}