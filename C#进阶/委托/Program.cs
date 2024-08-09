using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    #region 概念
    //委托是 函数（方法）的容器
    //可以理解为表示函数（方法）的变量类型
    //用来 存储、传递函数（方法）
    //委托的本质是一个类，用来定义函数（方法）的类型（返回值和参数的类型）
    //不同的 函数（方法）必须对应和各自“格式”一致的委托
    #endregion
    #region 基本语法
    //关键字：delegate
    //语法：访问修饰符 delegate 返回值 委托名（参数列表）

    //写在哪里？
    //可以申明在namespace和class语句块中
    //更多的写在namespace中


    #endregion
    #region 使用
    //访问修饰符默认不写 为public 在别的命名空间中也能使用
    //private 其他命名空间就不能用了
    //一般使用public

    //申明了一个可以用来存储无参无返回值函数的容器
    //这里只是定义了规则，并没有使用
    delegate void MyFun();

    //委托规则的申明 是不能重名的（同一语句块中）
    delegate int MyFun1(int a);//表示用来装载或传递 返回值为int 有一个int参数的函数的 委托 容器规则

    //委托是支持泛型的 可以让返回值和参数 可变
    delegate T MyFun3<T,K>(T a, K k);

    #endregion
    #region 使用定义好的委托
    //委托变量是函数的容器

    //委托常用在：
    //1.作为类的成员
    //2.作为函数的参数

    class Test
    {
        public MyFun fun;
        public MyFun1 fun1;

        public void TestFun(MyFun fun,MyFun1 fun1)
        {
            //先处理一些别的逻辑 当这些逻辑处理完了 再执行传入的函数
            int i = 1;


            fun();
            fun1(i);

            this.fun = fun;
            this.fun1 = fun1;
        }

        //增
        public void AddFun(MyFun fun,MyFun1 fun1) 
        {
            this.fun += fun;
            this.fun1 += fun1;
        }

        //减
        public void RemoveFun(MyFun fun, MyFun1 fun1)
        {
            this.fun -= fun;
            this.fun1 -= fun1;
        }
    }
    #endregion
    #region 委托变量可以存储多个函数（多播委托）

    #endregion
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //专门用来装载 函数的容器
            MyFun f=new MyFun(Fun);
            f.Invoke();
            
            MyFun f_ = Fun;
            f_();

            MyFun1 f1 = new MyFun1(Fun1);
            f1.Invoke(1);

            MyFun1 f1_=Fun1;
            f1_(1);

            Test t=new Test();
            t.TestFun(Fun,Fun1);

            //如何用委托存储多个函数
            MyFun ff = Fun;
            ff += Fun2;            
            ff();
            //移除指定函数
            ff -= Fun;
            ff();

            t.AddFun(Fun,Fun1);
            t.fun();
            t.fun1(1);

            #region 系统定义好的委托
            //需要引用命名空间using System;
            //无参无返回值时
            Action action = Fun;
            action += Fun;
            action();

            //可以指定返回值类型的 泛型委托
            Func<string> func = Fun3;
            Func<int> func2 = Fun4;

            //可以传n个参数的 系统提供了 直接用就可以(提供了16个）
            Action<int, string> action1 = Fun5;

            //可以传n个参数的 并且有返回值的 系统也提供了16个委托
            Func<int, int> f3 = Fun1;
            #endregion
        }
        static void Fun()
        {
            Console.WriteLine("123");
        }
        static void Fun2()
        {
            Console.WriteLine("李四");
        }
        static int Fun1(int value)
        {
            return value;
        }
        static string Fun3()
        {
            return"";
        }
        static int Fun4()
        {
            return 1;
        }
        static void Fun5(int i,string s)
        {

        }
    }
}
