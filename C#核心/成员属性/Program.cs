using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成员属性
{
    #region 概念
    //1.用于保护成员变量
    //2.为成员属性的获取和赋值添加逻辑处理
    //3.解决3P的局限性


    #endregion
    #region get和set前可以加访问修饰符
    //1.默认不加 会使用属性声明时的访问权限
    //2.加的访问修饰符要低于属性的访问权限
    //3.不能让get和set的访问权限都低于属性的权限
    #endregion
    #region get和set可以只有一个
    //只有一个时 没必要在前面加访问修饰符
    #endregion
    #region 自动属性
    //作用：外部能得不能改
    //如果类中有一个特征是只希望外部能得不能改的 又没什么特殊处理
    //则可以使用
    #endregion
    class Person
    {
        private int id;
        private string name;
        private int age;
        private bool sex;
        private int money;

        //属性的命名一般使用 帕斯卡命名法
        public string Name
        {
            get
            {
                //可以在返回之前添加一些逻辑规则
                //意味着 这个属性可以获取的内容
                return name;
            }
            set
            {
                //可以在设置之前添加一些逻辑规则
                //value 关键字 用于表示 外部传入的值
                name=value;
            }
        }
        public int Money
        {
            get //private get
            {
                //解密处理
                return money-5;
            }

            set //private set
            {
                //加密处理
                if(value<0)
                {
                    value = 0;
                    Console.WriteLine("钱不能为0");
                }
                money = value+5;
               
            }
        }
        public bool Sex
        {
            get
            {
                return sex;
            }
        }
        public float Age
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1= new Person();
            p1.Name = "xiao";
            Console.WriteLine(p1.Name);
            p1.Money = 5;
            Console.WriteLine(p1.Money);


        }
    }
}
