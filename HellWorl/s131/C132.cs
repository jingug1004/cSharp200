using System;
using System.Management.Instrumentation;

namespace HellWorl.s131
{
    public class C132
    {
        int[] era10 = {2}; // 2 기본 소수

        // int[] era10 = {2, 3, 5,7};  // 2~10까지의 기본 소수
        int[] eratemp; // 기본 소수에 의해 만들어진 소수
        int[] era; // 1~2^2^n까지 숫자로 채움

        int n; // 2^2^n까지의 소수
        // 2^2^n승 n이 1이면 4, 2면 16

        public C132(int n)
        {
            this.n = n;
        }
        // 1~2^2^n 채움(1, 2, 3, 4, ...2^2^n)

        public void Fill(int m)
        {
            // era = new int[(int){Math.Pow(10, (int)(Math.Pow(10, m)))}];
            era = new int[(int) (Math.Pow(2, (int) (Math.Pow(2, m))))];

            for (int i = 0; i < era.Length; i++)
            {
                era[i] = i + 1; // 1~2^2^n
            }
        }

        public void ReMake()
        {
            for (int i = 0; i < n; i++)
            {
                Make(i + 1);
            }
        }

        private void Make(int m)
        {
            Fill(m);
            int count = 0;
            for (int j = 0; j < era10.Length; j++)
            {
                for (int k = 0; k < era.Length; k++)
                {
                    // 나누어 떨어지는 수 제거
                    if (era[k] % era10[j] == 0)
                    {
                        // 원래 1이거나 나누어 떨어지는 수를 1로 바꿈
                        era[j] = 1;
                        count++;
                    }
                }
            }

            // 전체수 -1(1은 소수가 아님) -count(나누어 떨어지는 수)
            eratemp = new int[era.Length - count - 1];
            int te = 0;
            for (int l = 0; l < era.Length; l++)
            {
                if (era[l] != 1)
                {
                    // 1 인수를 제거하고 아닌 수만
                    eratemp[te++] = era[l];
                }
            }

            // 임시 배열 -> 기본 소수 + 기본 소수에서 얻은 소수
            int[] era10Twice = new int[eratemp.Length + era10.Length];

            // 기본 소수를 채움
            Array.Copy(era10, 0, era10Twice, 0, era10.Length);

            // 기본 소수에서 얻은 소수를 채움
            Array.Copy(eratemp, 0, era10Twice, era10.Length, eratemp.Length);

            // 추가된 소수를 기본 소수로 만듦
            era10 = new int[era10Twice.Length];
            Array.Copy(era10Twice, 0, era10, 0, era10Twice.Length);
        } // Make

        public void PrintErotos()
        {
            for (int m = 0; m < era10.Length; m++)
            {
                Console.Write("{0}\t", era10[m]);
                if ((m + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n2부터 {0}까지 약수 : {1}개", era.Length, era10.Length);
        }
    }
}