using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 顺序存储和链式存储
{
    #region 数据结构概念
    //数据结构
    //计算机存储、组织数据的方式（规则）
    //数据结构是指相互之间存在一种或多种特定关系的数据元素的集合
    //比如自定义的一个 类 也可以称为一种数据结构 自己定义的数据组合规则

    //即：人定义的 存储数据和表示数据之间关系 的规则
    //常用的数据结构
    //数组、栈、队列、链表、树、图、堆、散列表
    #endregion
    #region 线性表
    //线性表是一种数据结构，是由n个具有相同特性的数据元素的有限队列
    //比如数组、ArrayList、Stack、Queue、链表等


    #endregion
    #region 顺序存储
    //顺序存储和链式存储 是数据结构中两种存储结构

    //数组、Stack、Queue、List、ArrayList ——顺序存储
    //只是 数组、Stack、Queue的组织规则不同而已
    //顺序存储：用一组连续的存储单元依次存储线性表的各个数据元素
    #endregion
    #region 链式存储
    //单向链表、双向链表、循环链表——链式存储
    //链式存储（链接存储）
    //用一组任意的存储单元存储线性表中的各个数据元素
    #endregion
    #region 实现一个简单的单向链表
    class LinkedNode<T>
    {
        public T value;
        //这个存储下一个元素是谁
        public LinkedNode<T> nextNode;

        public LinkedNode(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// 单向链表类 管理 节点 管理添加等
    /// </summary>
    /// <typeparam name="T"></typeparam>
     class LindedList<T>
    {
        public LinkedNode<T> head;
        public LinkedNode<T> last;
        public void Add(T value)
        {
            //添加节点 必然是new一个新的节点
            LinkedNode<T> node = new LinkedNode<T>(value);
            if (head == null)
            {
                head = node;
                last = node;
            }
            else
            {
                last.nextNode = node;
                last = node;
            }
        }

        public void Remove(T value)
        {
            if (head == null)
            {
                return;
            }
            if (head.value.Equals(value))
            {
                head = head.nextNode;
                //如果头节点 被移除 发现头节点变空
                //证明只有一个节点 尾也要清空
                if (head == null)
                {
                    last = null;
                }
            }
            LinkedNode<T> node = head;
            while (node.nextNode != null)
            {
                if (node.nextNode.value.Equals(value))
                {
                    //让当前找到的这个元素的上一个节点
                    //指向 自己的下一个节点
                    node.nextNode = node.nextNode.nextNode;
                    break;
                }
            }
        }
    }

    #endregion
    #region 优缺点
    //增：链式存储 计算上 优于顺序存储（中间插入时链式不用像顺序一样去移动位置）
    //删：链式存储 计算上 优于顺序存储（中间删除时链式不用像顺序一样去移动位置）
    //查：顺序存储 使用上 优于链式存储（数组可以直接通过下标得到元素，链式需要遍历）
    //查：顺序存储 使用上 优于链式存储（数组可以直接通过下标得到元素，链式需要遍历）
    #endregion
    internal class Program
        {
            static void Main(string[] args)
            {
            
            LinkedNode<int> node = new LinkedNode<int>(1);
            LinkedNode<int> node1 = new LinkedNode<int>(2);
            node.nextNode = node1;


            LinkedList<int> list = new LinkedList<int>();
            
            while (node.nextNode != null)
            {
                Console.WriteLine(node.value);
                node= node.nextNode;
            }
            list.Remove(0);   


           
           
           
            
            



            }
        }
}

