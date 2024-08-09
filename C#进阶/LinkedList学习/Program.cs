using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList学习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //LinkedList是一个C#为我们封装好的类
            //它的本质是一个可变类型的泛型双向链表
            #endregion
            #region 使用
            //需要引用命名空间
            //using System.Collections.Generic

            LinkedList<int > linkedlist = new LinkedList<int>();
            LinkedList<string> linkedlist1= new LinkedList<string>();

            //链表对象 需要掌握两个类
            //一个是链表本身 一个是链表节点类LinkedListNode

            //增
            //1.在链表尾部添加元素
            linkedlist.AddLast(10);
            //2.在链表头部添加元素
            linkedlist.AddFirst(20);
            //3.在某一个节点之后添加一个节点
            //要指定节点 先得得到一个节点
            LinkedListNode<int> n = linkedlist.Find(20);
            linkedlist.AddAfter(n, 15);
            //4.在某一个节点之前添加一个节点
            //要指定节点 先得得到一个节点
            linkedlist.AddBefore(n, 20);

            //删
            //1.移除头节点
            linkedlist.RemoveFirst();
            //2.移除尾节点
            linkedlist.RemoveLast();
            //3.移除指定节点
            //无法通过位置直接移除
            linkedlist.Remove(20);
            //4.清空
            linkedlist.Clear();

            //查
            //1.头节点
            LinkedListNode<int> first=linkedlist.First;
            //2.尾节点
            LinkedListNode<int> last=linkedlist.Last;
            //3.找到指定值的节点
            //无法直接通过下表获取中间元素
            //只有遍历查找指定位置元素
            LinkedListNode<int> node=linkedlist.Find(10);//通过值来找节点
            Console.WriteLine(node.Value);
            node=linkedlist.Find(20);
            //4.判断是否存在
            if(linkedlist.Contains(1))
            {
                Console.WriteLine("链表中存在1");
            }

            //改
            //要先得再改
            linkedlist.First.Value = 10;
            Console.WriteLine(linkedlist.First.Value);
            #endregion
            #region 遍历
            //1.foreach遍历
            foreach(int item in linkedlist)
            {
                Console.WriteLine(item);
            }

            //2.通过节点遍历
            //从头到尾
            LinkedListNode<int> nowNode = linkedlist.First;
            while(nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Next;
            }
            //从尾到头
             nowNode = linkedlist.Last;
            while (nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Previous;
            }
            #endregion
        }
    }
}
