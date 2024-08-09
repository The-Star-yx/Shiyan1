using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref和out
{
    internal class Program
    {
        static void ChangeValue(int value)
        {
            value = 3;
        }
        static void ChangeArray(int[] array)
        {
            array[0] = 99;
        }
        static void ChangeArrayValue(int[] array)
        {
            array=new int[] {1,2,3};
        }
        static void ChangeValueRef(ref int value)
        {
           
        }
        static void ChangeArrayRef(ref int[] array)
        {
            array = new int[] { 1, 2, };
        }
        static void ChangeValueOut(out int value)
        {
            value = 3;
        }
        static void Main(string[] args)
        {
            #region 概念
            //他们可以解决 在函数内部改变外部传入的内容 里面变了 外面也要变

            int a = 1;
            ChangeValue(a);
            Console.WriteLine(a);

            int[] arr2 = { 1, 2, 3 };
            ChangeArray(arr2);
            Console.WriteLine(arr2[0]);

            ChangeArray(arr2);
            Console.WriteLine(arr2[0]);
            #endregion
            #region ref和out使用
            //函数参数修饰符
            //当传入的值类型参数在内部修改时 或者引用类型参数在内部重新声明
            //外部的值会发生变化
            int a2 = 1;
            ChangeValueRef(ref a2);
            Console.WriteLine(a2);

            int[] array= { 3, 4 };
            ChangeArrayRef(ref array);
            Console.WriteLine(array[1]);

            ChangeValueOut(out a2);
            Console.WriteLine(a2);


            #endregion
            #region 区别
            //1.ref传入的变量必须初始化 out不用
            //2.out传入的变量必须在内部赋值 ref不用

            //ref 买票上车 out 上车买票
            //ref传入的变量必须初始化 但是在内部 可改可不改
            //out传入的变量不用初始化 但是在内部 必须修改该值（必须重新赋值）

            int a6=1;
            int a8;
            ChangeValueRef(ref a6);
            ChangeValueOut(out a8);
            Console.WriteLine(a6);
            Console.WriteLine(a8);

            #endregion
            Console.ReadKey();  
        }
    }
}
