using System;
using System.ComponentModel;
using System.Management.Instrumentation;
using System.Text;

namespace HellWorl.s131
{
    public class C134
    {
        int[] lot;
        private int m; // 전체 공의 개수
        Random r;
        static int SEED = 17;

        public C134(int m)
        {
            Init(m);
        }

        private void Init(int m) // 0도 가능하므로 -1로 초기화
        {
            this.m = m;
            lot = new int[m];
            for (int i = 0; i < lot.Length; i++)
            {
                lot[i] = -1;
            }

            r = new Random(SEED++ + System.DateTime.Now.Millisecond);
        }

        private int NumMake()
        {
            return r.Next(m / 2); // 0 <= m/2 < 6
        }

        public void Make() // 같은 수를 임의의 위치에 두 개씩 넣기
        {
            int count = 0;
            while (count != lot.Length)
            {
                int temp = this.NumMake();
                // 0, 1개면 더 받을 수 있다.
                if (NumCount(temp) < 2)
                {
                    lot[count++] = temp;
                }
            }
        }

        public void ReMake()
        {
            Init(m);
            this.Make();
        }

        private int NumCount(int num)
        {
            int hasS = 0;
            for (int i = 0; i < lot.Length; i++)
            {
                if (lot[i] == num)
                {
                    hasS++;
                }
            }

            return hasS;
        }
    }
}