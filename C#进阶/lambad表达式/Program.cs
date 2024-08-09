using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lambad表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //可以将lamabad表达式理解为匿名函数的简写
            //它除了写法不同外
            //使用上和匿名函数一模一样
            //都是和委托或者事件 配合使用的
            #endregion
            #region 语法
            //（参数列表）=>
            //{
            //     函数体
            //};
            #endregion
            #region 使用
            //1.无参无返回值
            Action a=() =>
            {
                Console.WriteLine("无参无返回值");
            };
            a();
            a.Invoke();

            //2.有参
            Action<int> b = (int value) =>
            {
                Console.WriteLine("有参"+value);
            };
            b(2);

            //3.甚至参数类型都可以省略 参数类型或委托或事件容器一致
            Action<int> c = (value) =>
            {
                Console.WriteLine("省略参数类型的写法" + value);
            };
            c(1);

            //4.有返回值
            Func<int, int> d = (value) =>
            {
                Console.WriteLine("有返回值"+value);
                return value;
            };
            d(3);

            //其它传参使用和匿名函数一样
            //缺点也相同
            #endregion
            #region 闭包
            //内层的函数可以引用包含在它外层的函数的变量
            //即使外层函数的执行已经终止
            //注意：
            //该变量提供的值并非变量创建时的值，而是在父函数范围内的最终值

            Test t1=new Test();
            t1.DoSomething();
            #endregion
        }
      

    }
    class Test
    {
        public event Action action;

        public Test()
        {
            int value = 10;
            //这里形成了闭包
            //因为 当构造函数执行完毕时 其中申明的临时变量value的声明周期被改变了
            action = () =>
            {
                Console.WriteLine(value);
            };

            for(int i = 0; i < 10; i++)
            {
                //此index 非彼index(每次循环int 一个新的index）
                int index = i;

                action += () =>
                {
                    Console.WriteLine(i);
                };

                action += () =>
                {
                    Console.WriteLine(index);
                };
            }

        }

        public void DoSomething()
        {
            action();
        }
    }
}
