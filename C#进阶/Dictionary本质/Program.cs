using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary本质
            //可以将Dictionary理解为 拥有泛型的Hashtable
            //它也是基于键的哈希代码组织起来的 键/值对
            //键值对类型从Hashtable的object变为了可以自己制定的泛型

            #endregion
            #region 使用
            //需要引用命名空间 using System.Collections.Generic
            Dictionary<int,string> dictionary=new Dictionary<int,string>();

            //增
            //注意不能出现相同键
            dictionary.Add(1, "sdf");
            dictionary.Add(2, "dfs");
            dictionary.Add(3, "123");

            //删
            //1.只能通过键去删除
            //删除不存在的键 没反应
            dictionary.Remove(3);
            //2.清空
            dictionary.Clear();

            //查
            //1.通过键查看值
            //找不到会返回空
            Console.WriteLine(dictionary[1]);
            //2.查看是否存在
            //根据键检测
            if(dictionary.ContainsKey(2))
            {
                Console.WriteLine(dictionary[2]);
            }
            //根据值检测
            if(dictionary.ContainsValue("123"))
            {
                Console.WriteLine(dictionary[3]);
            }

            //改
            dictionary[1] = "df";
            Console.WriteLine(dictionary[1]);


            #endregion
            #region 遍历
            Console.WriteLine(dictionary.Count);

            //1.遍历所有键
            foreach(int item in dictionary.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(dictionary[item]);
            }
            //2.遍历所有值
            foreach(string item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            //3.键值对一起遍历
            foreach(KeyValuePair<int,string> pair in dictionary)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }

            #endregion
        }
    }
}
