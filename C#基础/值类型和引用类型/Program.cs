using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 区别
            //分类
            //引用类型：string 数组 类
            //值类型：有符号整形 浮点数 char bool等其他 结构体

            //区别：
            int a = 10;
            int[] arr = new int[] { 1, 2 };
            int b = a;
            int[] arr2 = arr;
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);

            b = 20;
            arr2[0] = 5;
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);


            //值类型 在相互赋值时 把内容拷贝给对方 它变我不变
            //引用类型 让两者指向同一个值          它变我也变

            //1.值类型和引用类型 存储在的内存区域是不同的 存储方式是不同的
            //值类型存储在 栈空间——系统分配 自动回收 小而快
            //引用类型 存储在 堆空间——手动申请和释放 大而慢（地址在栈 地址内容在堆）

            arr2 = new int[] { 99, 3, 1, 2, };
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);

            #endregion
            #region 特殊引用类型string
            //它具备 值类型特征 它变我不变
            string str1 = "123";
            string str2 = str1;
            str2 = "321";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            #endregion
            Console.ReadKey();
        }
    }
}
