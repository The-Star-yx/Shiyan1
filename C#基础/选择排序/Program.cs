using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //原理 
            //
            //新建中间商
            //依次比较
            //找出极值（最大或最小）
            //放入目标位置
            //比较n轮

            //冒泡排序一轮有多次交换位置 
            //选择排序一轮只交换一次位置

            int[] a = { 2, 1, 3, 4, 5, 6, 8, 7, 9};

           

            for(int i = 0; i < a.Length; i++)
            {
                //定义索引
                int index = 0;

                //依次比较
                for (int j = 0;j<a.Length-i;j++)
                {
                    //找出极值
                    if (a[j]>a[index])
                    {
                        index = j;
                    }
                }

                //放入目标位置
                //如果当前极值所在位置 就是目标位置 则不变
                if(index!=a.Length-1-i)
                {
                    int temp2 = a[index];
                    a[index] = a[a.Length-1-i];
                    a[a.Length -1 - i] = temp2;
                }

            }

            for(int i = 0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
