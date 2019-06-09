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

//            C132 instC132 = new C132(3);
//            instC132.ReMake();
//            instC132.PrintErotos();

//            C133 instC133 = new C133(45, 6);
//            instC133.Make();
////            instC133.Print();// 처음 만들기
//            instC133.ReMake();

            C134 instC134 = new C134(12);
            instC134.Make();
            instC134.ReMake();
        }
    }
}