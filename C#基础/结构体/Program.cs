using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    internal class Program
    {
        #region 基本语法
        //1.结构体一般写在namespace语句块中
        //2.结构体关键字struct

        //作用：
        //用来表现存在关系的数据集合 比如用结构体表现学生 动物 人类等

        //结构体申明的变量 不能直接初始化
        //变量类型 可以写任意类型 包括结构体 但是 不能是自己的结构体

        struct Student
        {
            public string Id;
            public int number;
            public Student(string Id, int number)
            {
                //新的关键字 this
                //代表自己
                this.Id = Id;
                this.number = number;

            }

        }
        


        #endregion
        #region 结构体的构造函数
        //1.没有返回值
        //2.函数名必须和结构体名相同
        //3.必须有参数
        //4.如果申明了构造函数 必须在其中对所有变量数据初始化


        #endregion
        static void Main(string[] args)
        {
            //使用
            //变量类型 变量名
            Student s;
            s.Id = "df";
         

            Student s2= new Student("sdf",123);
        }
    }
}
