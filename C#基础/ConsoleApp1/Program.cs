using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 4
            Random random = new Random();

            int[] a6 = new int[20];

            for (int i = 0; i < a6.Length; i++)
            {
                a6[i] = random.Next(0, 20);
            }

            for (int i = 0; i < a6.Length; i++)
            {
                int index = 0;
                for (int j = 0; j < a6.Length  - i; j++)
                {

                    if (a6[index] < a6[j])
                    {
                        index = j;
                    }
                }

                if (index != a6.Length - 1 - i)
                {
                    int temp1 = a6[index];
                    a6[index] = a6[a6.Length - 1 - i];
                    a6[a6.Length - 1 - i] = temp1;

                }
            }
            for (int i = 0; i < a6.Length; i++)
            {
                Console.WriteLine(a6[i]);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
