using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 内部类和分部类
{
    #region 内部类概念
    //在一个类中再申明一个类

    //特点
    //使用时用包裹者点出自己

    //亲密关系的变现

    #endregion
    class Person
    {
        public int age;
        public string name;
        
        public class Body
        {
            Arm leftArm;
            Arm rightArm;
            public class Arm
            {

            }
        }
    }
    #region 分布类概念
    //概念
    //把一个类分成几部分申明

    //关键字
    //partial

    //作用
    //分部描述一个类
    //增加程序的拓展性

    //注意
    //分布类可以写在多个脚本文件中
    //分布类的访问修饰符要一致
    //分布类中不能有重复成员
    #endregion
    #region 分部方法
    //将方法的申明和实现分离

    //1.不能加访问修饰符 默认私有
    //2.只能在分布类中申明
    //3.返回值只能是void
    //4.可以有参数但不用 out关键字
    #endregion
    partial class Student
    {
        public int age;
       
        public  void Speak()
        {
            Console.WriteLine("分部方法");
        }
        
    }
    partial class Student
    {
        public int number;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Person.Body body = new Person.Body();

            Person.Body.Arm arm = new Person.Body.Arm();

            Student student = new Student();
            student.number = 1;
            student.Speak();

            Console.Read();
        }
    }
}
