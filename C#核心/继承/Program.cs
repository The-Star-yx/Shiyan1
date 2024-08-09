using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    #region 概念
    //一个类A继承一个类B
    //类A将会继承类B的所有成员
    //A类将拥有B类的所有特征和行为

    //被继承的类
    //成为父类、基类、超类

    //子类可以有自己的特征和行为

    //特点
    //1.单根性 子类只能有一个父类
    //2.传递性 子类可以间接继承父类的父类


    #endregion
    #region 访问修饰符的影响
    //public 内外部访问
    //private 内部访问
    //protected 内部和子类访问

    //internal 内部 只有在同一个程序集的文件中，内部类型或是成员才可以访问
    #endregion
    #region 继承中的构造函数
    //不写返回值
    //函数名和类名相同
    //访问修饰符根据需求而定，一般为public
    //构造函数可以重载
    //可以用this语法重用代码

    //注意
    //有参构造会顶掉默认的无参构造
    //如有保留无参构造需重载出来

    //概念
    //特点：当申明一个子类对象时
    //先执行父类的构造函数，在执行子类的构造函数

    //注意：
    //1.父类的无参构造很重要
    //子类实例化时 默认自动调用的是父类的无参构造 所以如果父类无参构造被顶掉 会报错
    //解决方法：1.始终保持申明一个无参构造 2.通过base关键字 调用父类的构造
    //2.子类可以通过base关键字 代表父类 调用父类构造
    #endregion
    #region 密封类
    //使用sealed密封关键字修饰的类
    //作用：让类无法再被继承
    #endregion

    class Teacher
    {
        public string name;
        protected int number;

        public void SpeakName()
        {
            Console.WriteLine("name");
        }
    }
    class TeachingTeacher:Teacher
    {
        public string subject;
        public void SpeakSubject()
        {
            number = 10;
            Console.WriteLine("subject");
        }

    }
    class ChineseTeacher:TeachingTeacher
    {
        public string subject1;
        public void SpeakSubject_Chinese()
        {
            Console.WriteLine("subject");
        }
    }
    class Father
    {
        public Father()
        {

        }
        public Father(int i)
        {
            Console.WriteLine("Father构造");
        }
    }
    class Son : Father
    {
        public Son(int i):base(i) 
        {

        }
    }
    sealed class Son_son
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            TeachingTeacher t=new TeachingTeacher();
            t.SpeakSubject();
            t.SpeakName();
            ChineseTeacher chinese = new ChineseTeacher();
            chinese.SpeakSubject_Chinese();
            Father father = new Father();
        }
    }
}
