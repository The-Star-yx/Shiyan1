using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数和析构函数
{
    class Person
    {
        public string str;
        public int id;
        public Person()
        {          
            Console.WriteLine("构造函数时" );
        }
        public Person(string str) 
        {
            this.str = str;
            Console.WriteLine("构造函数时"+this.str);
        }
        public Person(int id)
        {
            this.id = id;
            Console.WriteLine(this.id);
        }
        public Person(string str,int id):this(str)
        {
           
            Console.WriteLine("构造函数时第二" );
        }
        ~Person ()
        {

        }

    }
   
    

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 构造函数
            //概念
            //在实例化对象时 会调用的用于初始化的函数
            //如果不写 默认存在一个无参构造函数

            //写法：
            //1.没有返回值
            //2.函数名和类名必须相同
            //3.没有特殊需求时 一般都是public
            //4.构造函数可以被重载
            //5.this代表当前调用该函数的对象自己

            //注意：
            //如果不自己实现无参构造函数而实现了有参构造函数
            //会失去默认的无参构造
            #endregion
            #region 构造函数特殊写法
            //可以通过this 重用构造函数代码
            //访问修饰符 构造函数名（参数列表）：this（参数1，参数2）
            #endregion
            #region 析构函数
            //当引用类型的堆内内存被回收时 会调用该函数
            //对于需要手动管理内存的语言（C++），需要在析构函数中做一些内存回收处理
            //但是C#中存在自动垃圾回收机制GC
            //所以几乎不会怎么使用析构函数 除非想在某一个对象被垃圾回收时 做一些特殊处理


            #endregion
            #region 垃圾回收机制
            //GC
            //垃圾回收的过程是在遍历堆（Heap）上动态分配的所有对象
            //通过识别它们是否被引用来确定哪些对象是垃圾，哪些对象仍要被使用
            //所谓垃圾就是没有被任何变量、对象引用的内容
            //垃圾就需要被回收释放

            //算法：
            //引用计数
            //标记清除
            //标记整理
            //复制集合

            //注意：
            //GC只负责堆（Heap）内存的垃圾回收
            //引用类型都是存在堆中的 所以它的分配和释放都需要通过垃圾回收机制来管理
            
            //栈（Stack）上的内存是由系统自动管理的
            //值类型在栈中分配内存的，他们有自己的生命周期，不用对他们进行管理，他们会自动分配和释放

            //C#中内存回收机制大致原理
            //0代内存    1代内存    2代内存
            //代概念：
            //代是垃圾回收机制使用的一类算法（分代算法）
            //新分配的对象都会被配置在第0代内存中
            //每次分配都可能会进行垃圾回收以释放内存（0代内存满时）

            //在一次内存回收过程开始时，垃圾回收器会认为堆中全是垃圾，会进行以下操作
            //1.标记对象 从根部（静态字段，方法参数）开始检查引用对象，标记后为可达对象，未标记为不可达对象
            //  不可达对象就认为是垃圾
            //2.搬迁对象压缩堆（挂起执行托管代码线程） 释放未标记的对象 搬迁可达对象 修改引用地址
            //大对象总被认为是第二代内存 目的是减少性能损耗，提高性能
            //不会对大对象进行搬迁压缩 85000字节（83kb）以上的对象为大对象
            #endregion
            Person a = new Person("sdf");
            Person b = new Person(123);

            Console.ReadKey();

            //手动触发垃圾回收
            //都是在Loading过场景时 才调用
            GC.Collect();
        }
       
    }
}
