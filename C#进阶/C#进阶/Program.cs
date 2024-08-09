using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList类
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //ArrayList是一个C#为我们封装好的类
            //它的本质是一个object类型的数组
            //ArrayList类帮助我们实现了很多方法，

            #endregion
            //申明需要引用命名空间
            ArrayList array = new ArrayList();
            ArrayList array1= new ArrayList();

            #region 使用

            //增
            array.Add(1);
            array.Add("df");
            array.Add(true);
            //范围增加 把另一个List容器里面的内容增加到里面
            array.AddRange(array1);

            //插入
            array.Insert(0, "df");
            Console.WriteLine(array[0]);

            //删
            //移除指定元素
            array.Remove(1);
            //移除指定位置的元素
            array.RemoveAt(0);
            //清空
            array.Clear();

            //查
            //得到指定位置的元素
            Console.WriteLine(array[0]);
            //查看元素是否存在
            if(array.Contains("df"))
            {
                Console.WriteLine("存在df");
            }

            //正向查找元素位置
            //找到的返回值 是位置 找不到 返回值是-1
            int index=array.IndexOf(true);
            Console.WriteLine(index);
            Console.WriteLine(array.IndexOf(false));

            //反向查找元素位置
            //返回从头开始的索引数
             index=array.LastIndexOf(true);
            Console.WriteLine(index);

            //改
            array[0] = "123";
            Console.WriteLine(array[0]);


            #endregion
            #region 遍历
            //长度
            Console.WriteLine(array.Count);
            //容量
            Console.WriteLine(array.Capacity);
            
            for(int j = 0;j<array.Count; j++)
            {
                Console.WriteLine(array[j]);
            }

            //迭代器遍历
            foreach(object item in array)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region 装箱拆箱
            //ArrayList本质上是一个可以自动扩容的object数组
            //由于用万物之父来存储数据，自然存在装箱拆箱

            int i = 1;
            array[0] = i;
            i = (int)array[0];
            #endregion
        }
    }
}
