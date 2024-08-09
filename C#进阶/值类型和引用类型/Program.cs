using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识回顾
            //值类型
            //无符号：byte，ushort，uint，ulong
            //有符号：sbyte，short，int，long
            //浮点数：float，double，decimal
            //特殊：char，bool
            //枚举：enum
            //结构体：struct

            //引用类型
            //string
            //数组
            //class类
            //interface
            //委托

            //本质区别
            //值类型和引用类型的本质区别
            //值的具体内容存在栈内存上 引用的具体内容存在堆内存上

            #endregion
            #region 如何判断 值类型和引用类型
            //进入类型的内部去看
            //class引用
            //struct值
            #endregion
            #region 语句块
            //命名空间
            //↓
            //类、接口、结构体
            //↓
            //函数、属性、索引器、运算符重载等（类、接口、结构体）
            //↓
            //条件分支、循环

            //上层语句块：类、结构体
            //中层语句块：函数
            //底层语句块：条件分支、循环等

            //逻辑代码写在哪里?
            //函数、条件分支、循环-中底层语句块中

            //变量申明？
            //上、中、底都能申明变量
            //上层语句块中：成员变量
            //中、底层语句块中：临时变量

            #endregion
            #region 变量的生命周期
            //编程大部分都是 临时变量
            //在中底层申明的临时变量（函数、条件分支、循环语句块等）
            //语句块执行结束
            //没有被记录的对象将被回收或变成垃圾
            //值类型：被系统自动回收
            //引用类型：栈上用于存地址的房间被系统自动回收，堆中具体内容变成垃圾

            //想要不被回收或者不变垃圾
            //必须将其记录下来
            //如何记录？
            //在更高层级记录或者使用静态全局变量记录
            #endregion
            #region 结构体中的值和引用
            //结构体本身是值类型
            //前提：该结构体没有做为其他类的成员
            //在结构体中的值，栈中存储值具体的内容
            //在结构体中的引用，堆中存储引用具体的内容

            //引用类型始终存储在堆中
            //真正通过结构体使用其中引用类型时只是顺藤摸瓜
            #endregion
            #region 类中的值和引用
            //类本身是引用类型
            //在类中的值，堆中存储具体的值
            //在类中的引用 堆中存储具体的值

            //值类型跟着大哥走，引用类型一根筋
            #endregion
            #region 数组中的存储规则
            //数组本身是引用类型
            //值类型数组，堆中房间存具体内容
            //引用类型数组，堆中房间存地址
            #endregion
            #region 结构体继承接口
            //利用里氏替换原则，用接口容器装载结构体存在装箱拆箱
            TestStruct obj = new TestStruct();
            obj.Value = 1;
            Console.WriteLine(obj.Value);
            TestStruct obj2 = obj;
            obj2.Value = 2;
            Console.WriteLine(obj.Value);
            Console.WriteLine(obj2.Value);

            ITest iobj1=obj;//装箱
            ITest iobj2 = iobj1;
            iobj2.Value = 3;
            Console.WriteLine(obj.Value);
            Console.WriteLine(obj2.Value);

            TestStruct iobj3 = (TestStruct)iobj1;//拆箱

            #endregion
        }
    }
    interface ITest
    {
        int Value
        {
            get; set;
        }
    }
    struct TestStruct : ITest
    {
        public int Value
        {
            get
            {
                return Value;
            }
            set
            {
                this.Value = value;
            }
        }
    }

}
