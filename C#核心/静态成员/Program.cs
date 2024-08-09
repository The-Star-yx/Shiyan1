using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态成员静态类
{
    #region 静态成员概念
    //关键字static
    //用static修饰的 成员变量、方法、属性等
    //特点：
    //直接用类名点出使用

    //程序中是不能无中生有
    //使用的对象都需要在内存中分配内存空间

    //静态成员的特点
    //程序开始运行时 会分配内存空间，所以我们就能直接使用。
    //静态成员和程序同生共死
    //只要使用了它，直到程序结束时内存空间才会被释放
    //所以一个静态成员就会有自己唯一的一个“内存小房间”
    //这让静态成员有了唯一性
    //在任何地方使用都是用的小房间里面的内容，改变了它也是改变小房间里面的内容。

    //静态函数中不能使用非静态成员
    //非静态函数中可以直接使用静态成员
    //成员变量只能将对象实例化出来后，才能点出使用 不能无中生有
    //不能直接使用 非静态成员 否则会报错

    //常量和静态变量
    //const（常量）可以理解为特殊的static（静态）
    //相同点
    //他们都可以通过类名点出使用
    //不同点：
    //1.const必须初始化，不能修改  static则没有这个规则
    //2.const只能修饰变量，static可以修饰很多
    //3.const一定是写在访问修饰符后面的，static没有这个要求
    #endregion
    #region 静态类概念
    //用static修饰的类
    //特点
    //只能包含静态成员
    //不能被实例化

    //作用
    //1.将常用的静态成员写在静态类中 方便使用
    //2.静态类不能被实例化 更能体现工具类的 唯一性
    //比如Console就是一个静态类


    #endregion
    #region 静态构造函数
    //在构造函数加上static修饰

    //特点
    //1.静态类和普通类都可以有
    //2.不能使用访问修饰符
    //3.不能有参数
    //4.只会自动调用一次
    #endregion
    static class Teste
    {
        public static int id;
        static Teste()
        {
            Console.WriteLine("静态类构造函数");
        }      

    }
    class Test
    {
        public const float G=9.8f;
        public static float PI = 3.1415f;
        public int test = 100;

        public static float Cd(float r)
        {
            return PI * r;
        }
        public void TR()
        {
            Console.WriteLine("123");
        }
         static Test()
        {
            Console.WriteLine("普通静态构造函数");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.Cd(1);
            Console.WriteLine(Test.PI);
            

         

            Console.ReadKey();
        }
    }
}
