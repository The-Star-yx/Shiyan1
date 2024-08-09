using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    #region 事件概念
    //事件是基于委托的存在
    //事件是委托的安全包裹 让委托的使用更具有安全性
    //事件是一种特殊的变量类型

    
    #endregion
    #region 事件的使用
    //申明语法：
    //访问修饰符 event 委托类型 事件名;

    //事件的使用：
    //1.事件是作为成员变量存在于类中
    //2.委托怎么用 事件就怎么用

    //事件相对于委托的区别：
    //1.不能在类外部 赋值
    //2.不能在类外部 调用
    //注意：
    //它只能作为成员存在于类和接口以及结构体中
    #endregion

    class Test
    {
        //委托成员变量 用于存储函数
        public Action myFun;
        //事件成员变量 用于存储函数
        public event Action MyEvent;

        public Test() 
        {
            myFun = TestFun;
            myFun += TestFun;
            myFun -= TestFun;
            myFun();
            myFun.Invoke();
            myFun = null;

            MyEvent = TestFun;
            MyEvent += TestFun;
            MyEvent -= TestFun;
            MyEvent = null;
            MyEvent();
            MyEvent.Invoke();
        }

        public void TestFun()
        {

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //委托可以在外部赋值
            test.myFun=null;
            test.myFun = TestFun;
            test.myFun -= TestFun;

            //事件是不能在外部赋值的
            //虽然不能赋值，但是可以加减 去添加移除记录的函数(只能用+=或-=）
            test.MyEvent += TestFun;
            test.MyEvent -= TestFun;

            //委托可以在外部调用
            test.myFun();
            test.myFun.Invoke();

            //事件不能在外部调用
            //只能在类的内部去封装 调用

            Action a = TestFun;
            //事件 是不能作为临时变量在函数中使用
            //event Action ae=TestFun;
        }

        public static void TestFun()
        {
            throw new NotImplementedException();
        }
    }
}
