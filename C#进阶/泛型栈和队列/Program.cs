using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型栈和队列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 变量
            //无符号
            //byte ushort uint ulong
            //有符号
            //sbyte short int long
            //浮点数
            //float double decimal
            //特殊
            //char bool string
            #endregion
            #region 复杂数据容器
            //枚举 enum
            //结构体 struct
            //数组（一维、二维、交错）[] [,] [][]
            //类
            #endregion
            #region 数据集合
            //ArrayList  object数据列表
            //Stack 栈   先进后出
            //Queue 队列 先进先出
            //Hashtable 哈希表 键值对

            #endregion
            #region 泛型数据集合
            //List 列表 泛型列表
            //Dictionary 字典 泛型哈希表
            //LinkedList 双向链表
            //Statck     泛型栈
            //Queue      泛型队列
            #endregion
            #region 使用
            //命名空间：using System.Collections.Generic
            //使用上和 Stack 和Queue 一模一样
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            Queue<object> queue2 = new Queue<object>();

            #endregion
        }
    }
}
