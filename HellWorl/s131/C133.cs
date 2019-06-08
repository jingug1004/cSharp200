using System;
using System.ComponentModel;
using System.Management.Instrumentation;
using System.Text;

namespace HellWorl.s131
{
    public class C133
    {
        private int[] lot; // 6개의 서로 다른 번호
        private int m; // 전체 공의 개수 45
        private int n; // 선택된 공의 개수 6
        private Random r; // 임의의 수를 만드는 클래스

        static int _seed = 17;

        public C133(int m, int n)
        {
            Init(m, n);
        }

        private void Init(int m, int n)
        {
            this.m = m;
            this.n = n;
            r = new Random(_seed++ + System.DateTime.Now.Millisecond);
        }

        private int NumMake() // 임의의 수 만들기 1~45
        {
            return r.Next(m) + 1; // 1~45 사이의 임의의 수 만들기
        }

        public void Make()
        {
            int count = 0;
            while (count != lot.Length)
            {
                int temp = this.NumMake();
                if (!this.Contains(temp))
                {
                    lot[count++] = temp;
                }
            }
        }

        public void ReMake() // 다시 만들기
        {
            Init(m, n);
            this.Make();
        }

        private bool Contains(int num)
        {
            bool hasS = false;
            for (int i = 0; i < lot.Length; i++)
            {
                if (lot[i] == num)
                {
                    hasS = true;
                    break;
                }
            }

            return hasS;
        }
    }
}