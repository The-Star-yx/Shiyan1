using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型数据结构类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List本质
            //List是一个C#为我们封装好的类
            //它的本质是一个可变类型的泛型数组
            //List类帮助我们实现了很多方法
            //比如泛型数组的增删查改
            #endregion
            #region 申明
            //需要引用命名空间
            //using System.Collections.Generic

            List<int> list = new List<int>();
            List<string> list2 = new List<string>();
            List<bool> list3 = new List<bool>();
            #endregion
            #region 使用
            //增
            //1.逐个增加
            list.Add(1);
            list.Add(2);
            list2.Add("str");
            //2.整体增加
            List<string> sdf = new List<string>();
            sdf.Add("df");
            list2.AddRange(sdf);
            //3.插入
            list.Insert(0, 99);
            Console.WriteLine(list[0]);

            //删
            //1.移除指定元素
            list.Remove(1);
            //2.移除指定位置元素
            list.RemoveAt(0);
            //3.清空
            list.Clear();

            //查
            //1.得到指定位置的元素
            Console.WriteLine(list[0]);
            //2.查看元素是否存在
            if(list.Contains(1))
            {
                Console.WriteLine("存在元素1");
            }
            //3.正向查找元素位置
            int index=list.IndexOf(2);
            Console.WriteLine(index);
            //4.反向查找元素位置
            //找到返回位置 找不到 返回-1
            index=list.LastIndexOf(1);
            Console.WriteLine(index);

            //改
            list[0] = 2;
            Console.WriteLine(list[0]);

            #endregion
            #region 遍历
            //1.长度
            Console.WriteLine(list.Count);
            //2.容量
            Console.WriteLine(list.Capacity);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
