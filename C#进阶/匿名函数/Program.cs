using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 匿名函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //没有名字的函数
            //匿名函数的使用主要是配合委托和事件进行使用
            //脱离委托和事件 是不会使用匿名函数的


            #endregion
            #region 基本语法
            //delegate （参数列表）

            //何时使用？
            //1.函数中传递委托参数时
            //2.委托或事件赋值时

            #endregion
            #region 使用
            //1.无参无返回值
            //这样申明匿名函数 只是在申明函数而已 还没有调用 真正调用它的时候 是这个委托容器啥时候调用 就什么时候调用
            Action a=delegate ()
            {
                Console.WriteLine("匿名函数逻辑");
            };

            a();

            //2.有参
            Action<int, string> b = delegate (int n, string m)
            {
                Console.WriteLine(n);
                Console.WriteLine(m);
            };
            b(5,"123");

            //3.有返回值
            Func<string> c = delegate ()
            {
                return "1";
            };
            c();

            //4.有参有返回值
            Func<int,int> d = delegate (int value)
            {
                Console.WriteLine(value);
                return value;
            };

            //5.一般情况会作为函数参数传递 或者 作为函数返回值
            Test t= new Test();
            Action ac = delegate ()
            {
                Console.WriteLine("随参数传入的匿名函数逻辑");
            };
            t.Dosomthing(50, ac);

            //参数传递
            t.Dosomthing(100, delegate ()
            {
                Console.WriteLine("随参数传入的匿名函数逻辑");
            });

            //作为返回值
            Action ac2=t.GetFun();
            ac2();
            //一步到位
            t.GetFun()();
            #endregion
            #region 缺点
            //添加到委托或事件容器中后 不记录 无法单独移除

            Action ac3 = delegate ()
            {
                Console.WriteLine("匿名函数一");
            };

            ac3 += delegate ()
            {
                Console.WriteLine("匿名函数二");
            };

            ac3();
            //因为匿名函数没有名字 所有没有办法指定移除某一个匿名函数
            //只能清空
            ac3 = null;
            #endregion
        }
        static void TestFun()
        {

        }
       

    }
    class Test
    {
        public Action action;

        //作为参数传递时
        public void Dosomthing(int a,Action fun)
        {
            Console.WriteLine(a);
            fun();
        }

        //作为返回值
        public Action GetFun()
        {
            return delegate () {
                Console.WriteLine("函数内部返回的一个匿名函数逻辑");
            };
        }
    }
}
