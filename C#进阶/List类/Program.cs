using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List本质
            //List是一个C#为我们封装好的类
            //它的本质是一个可变类型的泛型数组
            //List类帮助我们可以实现很多方法
            #endregion
            #region 使用
            //申明需要引用命名空间
            //using System.Collections.Generic
            List<string> list = new List<string>();
            List<bool> list2 = new List<bool>();

            //增
            //1.单个增加
            list.Add("123");
            //2.整体增加
            List<string> list3= new List<string>();
            list3.Add("dfs");
            list.AddRange(list3);
            //3.插入
            list.Insert(1, "df");

            //删
            //1.移除指定元素
            list.Remove("123");
            //2.移除指定位置元素
            list.RemoveAt(0);
            //3.清空
            list.Clear();

            //查
            //1.得到指定位置元素
            Console.WriteLine(list[0]);
            //2.查看元素是否存在
            if(list.Contains("123"))
            {
                Console.WriteLine("存在元素123");
            }
            //3.正向查找元素位置
            //找到返回位置 找不到 返回-1
            int index=list.IndexOf("123");
            Console.WriteLine(index);
            //4.反向查找元素位置
            //找到返回位置 找不到 返回-1
            index=list.LastIndexOf("123");
            Console.WriteLine(index);

            //改
            list[0] = "dfs";


            #endregion
            #region 遍历
            //1.长度
            Console.WriteLine(list.Count);
            //2.容量
            Console.WriteLine(list2.Capacity);
            //3.遍历
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach(string item in list) 
            { 
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
