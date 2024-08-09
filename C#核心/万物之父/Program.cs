using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万物之父
{
    #region 概念
    //关键字：object
    //object是所有类型的基类，它是一个类（引用类型）
    //作用：
    //1.可以利用里氏替换原则，用object容器装所有对象
    //2.可以用来表示不确定类型，作为函数参数类型
    #endregion
    #region 使用
    class Son
    {
        public void Speak()
        {

        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = new Son();
            if(o is Son)
            {
                (o as Son).Speak();
            }

            object o2 = 1f;
            float f=(float)o2;

            object str= "123";
            string str2=str as string;

            object arr = new int[10];
           // int[] ar=arr as int[];或下面这行
            int[] ar = (int[])arr;

            #region 装箱拆箱
            //发生条件
            //用object存值类型（装箱）
            //再把object转为值类型（拆箱）

            //装箱
            //把值类型用引用类型存储
            //栈内存迁移到堆内存中

            //拆箱
            //把引用类型存储的值类型取出
            //堆内存会迁移到栈内存中

            //好处：不确定类型时可以方便参数的存储和传递
            //坏处：存在内存迁移，增加性能消耗


            #endregion

        }
    }
}
