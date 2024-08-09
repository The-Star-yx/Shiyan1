using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数
{
    internal class Program
    {
         static void SayHello()
        {
            Console.WriteLine("你好");
        }
        static void SayYourName(string name)
        {
            Console.WriteLine("名字：{0}",name);
        }
        static string WhatYourName()
        {
            return "xiao";
        }
        static int Sum(int a,int b)
        {
            return a + b;
            
        }
        static int[] Cale(int a,int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            return new int[]{ sum, avg };
        }
            
        static void Main(string[] args)
        {
            #region 概念
            //方法
            //1.封装代码
            //2.提升复用率
            //3.抽象行为

            //1.class语句块中
            //2.struct语句块中
            #endregion
            #region 语法
            //void 无返回值 函数名用帕斯卡命名法命名
            //参数用驼峰命名法命名
            //返回值可以写任意变量类型
            //
            #endregion
            #region 函数使用
            SayHello();
            SayYourName(Console.ReadLine());
            SayYourName(WhatYourName());
            Console.WriteLine(Sum(1, 2));

            int []ar=Cale(4,2);
            Console.WriteLine(ar[0] +" " +ar[1]);
            #endregion

            Console.ReadKey();
        }
    }
}

