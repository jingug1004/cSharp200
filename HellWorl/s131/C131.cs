using System;

namespace HellWorl.s131
{
    public class C131
    {
//        public void c131method()
//        {
//            Console.WriteLine("Hello World");
//        }
        public bool IsPrime(int n)
        {
            bool isP = true;
            for (int i = 2; i <= (int) (Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    isP = false;
                    break;
                }
            }

            return isP;
        }

        public void PrintPrime(int n)
        {
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i)) // IsPrime(i) == true 동일
                {
                    Console.Write("{0}\t", i);
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("2부터 {0} 까지 약수 : {1}개", n, count);
        }
    }
}