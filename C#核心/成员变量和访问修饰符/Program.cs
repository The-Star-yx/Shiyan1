using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成员变量和访问修饰符
{
    #region 访问修饰符
    //public
    //private
    //protected  自己和子类才能访问和使用
    #endregion
    enum E_SexType
    {
        man,
        woman
    }
    struct Position
    {

    }
    class Pet
    {

    }
    
    class Person
    {
       public string name;
       public int age;
        E_SexType sex;

        //如果在类中申明一个和自己相同类型的成员变量时
        //不能对它进行实例化
        Person[] girlFriend;
        Person[] womanFriend;
        Position p1;
        Pet p2;

        #region 成员方法申明
        //1.申明在类语句块中
        //2.是用来描述对象的行为
        //3.规则和函数申明规则相同
        //4.受到访问修饰符规则影响
        //5.返回值参数不做限制
        //6.方法数量不做限制

        //注意：
        //1.成员方法 不要加static关键字
        //2.成员方法 必须实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
        //3.成员方法 会受到访问修饰符影响
        #endregion
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}",name,str);
        }
        public bool Isadult()
        {
            return age >= 18;
        }

    }
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Person p = new Person();
            p.age = 20;
            p.name = "xiao";
            p.Speak("sdf");

            if(p.Isadult())
            {
                Console.WriteLine("已经");
            }
            #region 成员变量的使用和初始值
            //值类型来说 数字类型 默认值为0 bool类型 false
            //引用类型 null
            //default(变量类型） 能得到默认值
            Console.WriteLine(default(int));

            Console.ReadKey();
            #endregion
        }
    }
}
