using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    class Test
    {
        private int i = 1;
        public int j = 0;
        public string str = "123";

        public Test()
        {
            
        }
        public Test(int i)
        {
            this.i = i;
        }

        public Test(int i,string str) : this(i)
        {
            this.str = str;
        }

        public void Speak()
        {
            Console.WriteLine(i);
        }
    }
    #region 什么是程序集
    //程序集是经由编译器编译得到的，供进一步编译执行的那个中间产物
    //在Windows系统中，它一般表现为后缀为 .dll（库文件）或者是 .exe（可执行文件）的格式


    #endregion
    #region 元数据
    //元数据就是用来描述数据的数据
    //这个概念不仅仅用于程序上，在别的领域也有元数据

    //即：程序中的类，类中的函数、变量等等信息就是程序的元数据
    //有关程序以及类型的数据被称为 元数据，它们保存在程序集中

    #endregion
    #region 反射概念
    //程序在运行时，可以查看其他程序集或者自身的元数据
    //一个运行的程序查看本身或者其它程序的元数据的行为就叫做反射

    //即：
    //在程序运行时，通过反射可以得到其他程序集或者自己程序集代码的各种信息
    //类、函数、变量、对象等，实例化它们，执行他们，操作他们

    //作用：
    //因为反射可以在程序编译后获得信息，所以它提高了程序的拓展性和灵活性
    //1.程序运行时得到所有元数据，包括元数据的特性
    //2.程序运行时，实例化对象，操作对象
    //3.程序运行时创建新对象，用这些对象执行任务
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 反射使用
            #region Type类
            //Type（类的信息类）
            //它是反射功能的基础
            //它是访问元数据的主要方式
            //使用Type的成员获取有关类型声明的信息
            //有关类型的成员（比如构造函数、方法、字段、属性和类的事件）



            //获取Type
            //1.万物之父object中的GetType()可以获取对象的Type
            int a = 42;
            Type type=a.GetType();
            Console.WriteLine(type);

            //2.通过typeof关键字 传入类名 也可以得到对象的Type
            Type type1 = typeof(int);
            Console.WriteLine(type1);

            //3.通过类的名字 也可以获取类型
            //注意：类名必须包含命名空间 不然找不到
            Type type2 = Type.GetType("System.Int32");
            Console.WriteLine(type2);


            //可以通过Type得到类的程序集信息
            Console.WriteLine(type.Assembly);


            //获取类中的所有公共成员
            //需要引用命名空间 using System.Reflection;
            //首先得到Type
            Type t = typeof(Test);
            //然后得到所有公共成员
            MemberInfo[] infos = t.GetMembers();
            for(int i = 0; i < infos.Length; i++)
            {
                Console.WriteLine(infos[i]);
            }


            //获取类的公共构造函数并调用
            //1.获取所有构造函数
            ConstructorInfo[] ctors = t.GetConstructors();
            for(int i = 0;i < ctors.Length; i++)
            {
                Console.WriteLine(ctors[i]);
            }

            //2.获取其中一个构造函数 并执行
            //得到构造函数传入 Type数组 数组中内容按照顺序是参数类型
            //执行构造函数传入 object数组 表示按顺序传入的参数
            //2-1得到无参构造
            ConstructorInfo info = t.GetConstructor(new Type[0]);
            //执行无参构造 无参构造没有参数 传null
            Test obj=info.Invoke(null) as Test;
            Console.WriteLine(obj.j);

            //2-2得到有参构造
            ConstructorInfo info2=t.GetConstructor(new Type[]{ typeof(int)});
            obj=info2.Invoke(new object[] { 2 })as Test;
            Console.WriteLine(obj.str);

            //2-3两个参数
            ConstructorInfo info3=t.GetConstructor(new Type[] { typeof(int),typeof(string)});
            obj=info3.Invoke(new object[] {4,"444"}) as Test;
            Console.WriteLine(obj.str);


            //获取类的公共成员变量
            //1.得到所有成员变量
            FieldInfo[] fields = t.GetFields();
            for(int i = 0;i<fields.Length;i++)
            {
                Console.WriteLine(fields[i]);
            }

            //2.得到指定名称的公共成员变量
            FieldInfo infoj = t.GetField("j");
            Console.WriteLine(infoj);

            //3.通过反射获取和设置对象的值
            Test test= new Test();
            test.j = 99;
            test.str = "2222";
            //3-1通过反射 获取对象的某个变量的值
            Console.WriteLine(infoj.GetValue(test));
            //3-2通过反射 设置指定对象的某个变量的值
            infoj.SetValue(test, 100);
            Console.WriteLine(infoj.GetValue(test));


            //获得类的公共成员方法
            //通过Type类中的GetMethod方法 得到类中的方法
            //MethodInfo 是方法的反射信息
            Type strTtpe = typeof(string);

            //1.如果存在方法重载 用Type数组表示参数类型
            MethodInfo[] methods=strTtpe.GetMethods();
            for(int i = 0; i<methods.Length;i++)
            {
                Console.WriteLine(methods[i]);
            }
            MethodInfo subStr = strTtpe.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            //2.调用该方法
            //注意：如果是静态方法 Invoke中的第一个参数传null即可
            string str = "HEllo";
            //第一个参数 相当于 是哪个对象要执行这个成员方法
            object result = subStr.Invoke(str, new object[] { 7, 5 });
            Console.WriteLine(result);
            #endregion
            #region Activator
            //用于快速实例化对象的类
            //用于将Type对象快速实例化为对象
            //先得到Type
            //然后 快速实例化一个对象
            Type testType = typeof(Test);

            //1.无参构造
            Test testObj = Activator.CreateInstance(testType) as Test;
            Console.WriteLine(testObj.str);

            //2.有参构造
            testObj = Activator.CreateInstance(testType, 99) as Test;
            Console.WriteLine(testObj.j);
            #endregion
            #region Assembly
            //程序集类
            //主要用来加载其他程序集 加载后才能用Type来使用其他程序集中的信息
            //如果想要使用不是自己程序集中的内容 需要先加载程序集
            //比如 dll文件（库文件）
            //简单把库文件看成一种代码仓库，它提供给使用者一些可以直接拿来用的变量、函数或类

            //三种加载程序集的函数
            //一般用来加载在同一文件下的其他程序集
            //Assembly asembly2=Assembly.Load（"程序集名称");

            //一般用来加载不在同一文件下的其他程序集
            //Assembly asembly=Assembly.LoadFrom("包含程序集清单的文件的名称或路径");
            //Assembly asembly3=Assembly.LoadFile("要加载的文件的完全限定路径");

            //1.先加载一个指定程序集
            Assembly asembly = Assembly.LoadFrom(@"");
            Type[] types=asembly.GetTypes();
            for(int i=0; i<types.Length;i++)
            {
                Console.WriteLine(types[i]);
            }

            //2.再加载程序集中的一个类对象 之后才能使用反射
            Type icon = asembly.GetType("");
            MemberInfo[] members= icon.GetMembers();
            for(int j=0; j<members.Length;j++)
            {
                Console.WriteLine(members[j]);
            }
            //通过反射 实例化一个 icon对象
            //首先得到类对象 来得到可以传入的参数
            Type moveDir = asembly.GetType("");
            FieldInfo right = moveDir.GetField("");

            //直接实例化对象
            object iconObj=Activator.CreateInstance(icon);

            //得到对象中的方法 通过反射
            MethodInfo mov = icon.GetMethod("");
            #endregion
            #endregion
        }
    }
}
