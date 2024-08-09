using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数重载
{
    internal class Program
    {
        static int C(int a,int b)
        {
            return a + b;
        }
        static int C(int a,int b,int c) 
        {
            return a + b + c;
        }
        static float C(float a,float b)
        {
            return a + b;
        }
        static float C(float a,float b,int c)
                {
            return a + b + c;
        }
        static float C(int a,float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            #region 概念
            //在同一语句块（class或者struct）中
            //函数（方法）名相同 参数数量不同
            //或者参数数量相同 但参数的类型或顺序不同

            //作用：
            //1.命名一组功能相似的函数 减少函数名的数量 避免命名空间的污染
            //2.提升程序的可读性
            #endregion
            #region 实例
            Console.WriteLine(C(1, 2));
            Console.WriteLine(C(1,2, 3));


            #endregion

        }
    }
}
