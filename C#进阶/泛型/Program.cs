using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    #region 概念
    //泛型实现了类型参数化，达到代码重用的目的
    //通过类型参数化来实现同一份代码上操作多种类型

    //泛型相当于类型占位符
    //定义类或方法时使用替代符代表指定类型
    //当真正使用类或者方法时再具体指定类型

    //作用
    //1.不同类型对象的相同逻辑处理就可以选择泛型
    //2.使用泛型可以一定程度避免装箱拆箱
    //例如：优化ArrayList


    //总结
    //1.申明泛型时 它只是一个类型的占位符
    //2.泛型真正起作用的时候 是在使用它的时候
    //3.泛型占位字母可以有n个用逗号分开
    //4.泛型占位字母一般是大写字母
    //5.不确定泛型类型时 获取默认值 可以使用default（占位字符）
    //6.看到<>包括的字母 肯定是泛型
    class ArrayList<T>
    {
        private T[] array;

        public void Add(T value)
        {

        }

        public void Remove(T value) 
        {
            
        }
    }


    #endregion
    #region 泛型类
    //泛型类
    //基本语法
    class TestClass<T>
    {
        public T value;
    }
    class TestClass2<T1, T2, K>
    {
        public T1 value;
        public T2 value1;
        public K value2;
    }
    interface TestInterface<T>
    {
        T Value
        {
            get;
            set;
        }
    }
    class Test2 : TestInterface<int>
    {

        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    #endregion
    #region 泛型方法
    //1.普通类中的泛型方法
    class Test3
    {
        public void TestFun<T>(T value)
        {
            Console.WriteLine(value);
        }
        public void TestFun<T>()
        {
            //T t = default(T);
        }
        public T TestFun<T>(string v)
        {
            return default(T);
        }
        public void TestFun<T,K,M>(T t,K k,M m)
        {

        }
    }

    //2.泛型类中的泛型方法
    class Test4<T>
    {
        public T value;

        //这个是泛型方法
        public void TestFun<K>(K k)
        {
            Console.WriteLine(k);
        }

        //这个不是泛型方法
        public void TestFun(T t)
        {
            Console.WriteLine(t);
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> t = new TestClass<int>();
            t.value = 10;
            Console.WriteLine(t.value);

            TestClass<string> t2= new TestClass<string>();
            t2.value = "hello";
            Console.WriteLine(t2.value);

            TestClass2<string,int,float> t3= new TestClass2<string,int,float>();

            Test3 t5 = new Test3();
            t5.TestFun<int>(5);

            Test4<int> t7 = new Test4<int>();
            t7.TestFun<string>("He");
        }
    }
}
