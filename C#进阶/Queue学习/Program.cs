using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue学习
{
    class Test
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //Queue是一个C#为我们封装好的类
            //它的本质也是object[]数组，只是封装了特殊的存储规则

            //Queue是队列存储容器
            //队列是一种先进先出的数据结构
            //先存入的数据先获取，后存入的数据后获取
            //先进先出
            #endregion
            #region 使用
            Queue queue = new Queue();

            //增
            queue.Enqueue(1);
            queue.Enqueue("123");
            queue.Enqueue(new Test());

            //取
            //队列中不存在删除的概念
            //只有取的概念 取出先加入的对象
            object v=queue.Dequeue();
            Console.WriteLine(v);

            //查
            //1.查看队列头部元素但不会移除
            v=queue.Peek();
            Console.WriteLine(v);
            //2.查看元素是否存在于队列中
            if(queue.Contains("123"))
            {
                Console.WriteLine("存在");
            }

            //改
            //队列无法改变其中的元素 只能进出队列
            //实在要改 只有清
            queue.Clear();


            #endregion
            #region 遍历
            //1.长度
            Console.WriteLine(queue.Count);

            //2.用foreach遍历
            //打印顺序是先进先出
            foreach(object item in queue)
            {
                Console.WriteLine(item);
            }

            //3.转为object数组
            object[] array= queue.ToArray();
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //4.循环出列
            while(queue.Count > 0)
            {
                object o = queue.Dequeue();
                Console.WriteLine(o);
            }
            #endregion
            #region 装箱拆箱

            #endregion
        }
    }
}
