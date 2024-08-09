using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 拓展方法
{
    static class Tools
    {
        //为int拓展了一个成员方法
        //成员方法 是需要 实例化对象后 才能使用
        //value代表 使用该方法的实例化对象
        public static void SpeakValue(this int value)
        {
            Console.WriteLine("拓展方法"+value);

        }
        public static void SpeakString(this string value,string s1,string s2)
        {
            Console.WriteLine("拓展string方法" + value);
            Console.WriteLine("传入的参数"+s1+s2);
        }

        //为自定义类型拓展方法
        public static void Test2(this Test a,string name, int id)
        {
            Console.WriteLine("为Test拓展的方法:"+name+id);
        }
        public static void Fun2(this Test a,string name,int id)
        {
            Console.WriteLine("为Test拓展的方法2" + a+name+id);
        }
    }
    #region 概念
    //为现有非静态 变量类型 添加 新方法
    //作用
    //1.提升程序拓展性
    //2.不需要在对象中重新写方法
    //3.不需要继承来添加方法
    //4.为别人封装的类型写额外的方法

    //特点
    //1.一定是写在静态类中
    //2.一定是个静态函数
    //3.第一个参数为拓展目标
    //4.第一个参数用this修饰

    //语法
    //访问修饰符 static 返回值 函数名（this 拓展类名 参数名，参数类型 参数名，。。。）



    #endregion
    class Test
    {
        public int i = 10;
        public void Fun1()
        {
            Console.WriteLine("123");
        }
        public void Fun2()
        {
            Console.WriteLine("456");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            i.SpeakValue();
            string n = "dfs";
            n.SpeakString("fdf","dfsf");

            Test t = new Test();
            t.Fun2();
            t.Test2("A",5);
          
            Console.ReadKey();  
        }
    }
}
