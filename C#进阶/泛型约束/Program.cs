using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 泛型约束
{
   

    #region 概念
    //让泛型的类型有一定的限制
    //关键字：where
    //泛型约束一共有六种
    //1.值类型                                 where 泛型字母：struct
    //2.引用类型                               where 泛型字母：class
    //3.存在无参公共构造函数                   where 泛型字母：new（）
    //4.某个类本身或者其派生类                 where泛型字母：类名
    //5.某个接口的派生类型                     where泛型字母：接口名
    //6.另一个泛型类型本身或者派生类型         where泛型字母：另一个泛型字母
    #endregion
    #region 值类型约束
    class Test<T>where T : struct
    {
        public T value;

        public void TestFun<K>(K value)where K:struct
        {

        }

       
    }
    class Test2<T> where T : class
    {
        public T value;

        public void TestFun<K>(K value) where K : class
        {

        }

       
    }
    #endregion
    #region 公共无参构造约束
    class Test3<T>where T:new()
    {
        public T value;

        public void TestFun<K>(K value) where K : new()
        {

        }
    }
    class Test1
    {

    }
    class Test2
    {
        public Test2(int a)
        {

        }
    }
    #endregion
    #region 类约束
    class Test4<T> where T : Test1
    {
        public T value;

        public void TestFun<K>(K value) where K : Test1
        {

        }
        class Test3 : Test1
        {

        }


    }
    #endregion
    #region 接口约束
    interface IFly
    {

    }
    interface IMove : IFly
    {

    }
    class Test5<T> where T : IFly
    {
        public T value;

        public void TestFun<K>(K value) where K : IFly
        {

        }
        class Test4 : IFly
        {

        }
        

    }
    #endregion
    #region 另一个泛型约束
    class Test6<T,U> where T : U
    {
        public T value;

        public void TestFun<K,V>(K value) where K :V
        {

        }



    }
    #endregion
    #region 约束的组合使用
    class Test7<T> where T : class, new()
    { 

    }

    #endregion
    #region 多个泛型有约束
    class Test<T,K>where T:class,new()where K:struct
    {

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Test<int> test = new Test<int>();
            test.TestFun<float>(1.3f);

            Test2<Random> t=new Test2<Random>();
            t.value=new Random();

            Test3<int> t3 = new Test3<int>();   

            Test4<Test1> t4= new Test4<Test1>();
            
            Test5<IFly> t5= new Test5<IFly>();
            Test5<IMove> t6= new Test5<IMove>();

            
        }
    }
}
