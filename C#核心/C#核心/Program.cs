using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{
    internal class Program
    {
        //类对象 都是引用类型
        class Student
        {
            //特征-成员变量
            //行为-成员方法
            //保护特征-成员属性

            //构造函数和析构函数
            //索引器
            //运算符重载
            //静态成员
        }
        static void Main(string[] args)
        {
            //实例化类：
            //1.类名 变量名；
            //2.类名 变量名=null（null代表空）
            //3.类名 变量名=new 类名（）
            Student s1= new Student();
        }
    }
}
