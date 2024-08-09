using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack类
{
    class Test
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //Stack（栈）是一个C#为我们封装好的类
            //它的本质也是object[]数组，只是封装了特殊的存储规则

            //Stack是栈存储容器，栈是一种先进后出的数据结构
            //先存入的数据后获取，后存入的数据先获取
            //栈是先进后出

            //需要引用命名空间 System.Collections

            Stack stack = new Stack();
            #endregion
            #region 使用
            //增
            stack.Push(1);
            stack.Push("123");
            stack.Push(new Test());

            //取
            //栈中不存在删除的概念 只有取的概念
            //弹栈
            object v=stack.Pop();
            Console.WriteLine(v);//取new Test
            v= stack.Pop();
            Console.WriteLine(v);//取123

            //查
            //栈无法查看指定位置的元素 只能查看栈顶的内容
            v=stack.Peek();
            Console.WriteLine(v);
            //查看元素是否存在于栈中
            if(stack.Contains("123"))
            {
                Console.WriteLine("存在123");
            }

            //改
            //栈无法改变其中元素 只能压和弹
            //实在要改，只能清空
            stack.Clear();


            #endregion
            #region 遍历
            //1.长度
            Console.WriteLine(stack.Count);

            //2.用foreach遍历
            //而且遍历出来的顺序，也是从栈顶到栈底
            foreach(object item in stack)
            {
                Console.WriteLine(item);
            }

            //3.将栈转换为object数组
            //遍历的顺序 也是从栈顶到栈底
            object[] array= stack.ToArray();
            for(int j=0; j<array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            //4.循环弹栈
            while(stack.Count > 0)
            {
                object o=stack.Pop();
                Console.WriteLine(o);
            }


            #endregion
            #region 装箱拆箱
            object i = 1;
            Stack i1 = (Stack)i;

            object st = "123";
            Stack stt = st as Stack;
            #endregion


        }
    }
}
