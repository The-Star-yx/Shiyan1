using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //原理
            //两两相邻
            //不停比较
            //不停交换
            //比较n轮
            int[] a = { 4, 2, 3, 5, 1, 6, 7, 8, };
            int temp;
            bool isSort = false;
            for (int i = 0; i < a.Length-1; i++)
            {
                //每一轮开始时 默认没有进行过交换
                isSort = false;
                //进入一轮循环 需要比较一轮
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    //如果第j个数 比第j+1个数 大 他们就要交换位置
                    if (a[j] > a[j + 1])
                    { 
                        isSort = true;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
                //当一轮过后 如果isSort标识 还是false
                //则已经是最终序列 不需要再判断交换了
                if(!isSort)
                {
                    break;
                }
            }
            for(int i = 0;i < a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();

        }
        
    }
}
