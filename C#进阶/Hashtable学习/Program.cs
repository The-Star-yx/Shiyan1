using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable学习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 概念
            //Hashtable(又称为散列表） 是基于键的哈希代码组织起来的 键值对
            //它的作用是提高数据查询的效率
            //使用键来访问集合中的元素

            #endregion
            #region 使用
            Hashtable hashtable = new Hashtable();

            //增
            //不能出现相同键
            hashtable.Add(1, "123");
            hashtable.Add("123", 2);
            hashtable.Add(true,false); 
            hashtable.Add(false,true);
            
            //删
            //1.只能通过键去删除
            hashtable.Remove(1);//去除（1，“123”）
            //2.删除不存的键 没反应
            hashtable.Remove(2);
            //3.或者直接清空
            hashtable.Clear();

            //查
            //1.通过键查看值
            //找不到会返回空
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable["123123"]);
            //2.查看是否存在
            //根据键检测
            if(hashtable.Contains("2"))
            {
                Console.WriteLine("存在键为2的键值对");
            }
            if(hashtable.ContainsKey("3"))
            {
                Console.WriteLine("存在键为3的键值对");
            }
            //根据值检测
            if(hashtable.ContainsValue("123"))
            {
                Console.WriteLine("存在值为123的键值对");
            }

            //改
            //只能改 键对应的值内容 无法修改键
            hashtable[1] = 0.5f;
            Console.WriteLine(hashtable[1]);
            #endregion
            #region 遍历
            //得到键值对 对数
            Console.WriteLine(hashtable.Count);

            //1.遍历所有键
            foreach(object item in hashtable.Keys)
            {
                Console.WriteLine("键："+item);
                Console.WriteLine("值："+hashtable[item]);
            }

            //2.遍历所有值
            foreach(object item in hashtable.Values)
            {
                Console.WriteLine("值：" + item);
            }

            //3.键值对一起遍历
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine("键："+item.Key+"值"+item.Value);
            }

            //4.迭代器遍历法
            IDictionaryEnumerator myEnumerator =hashtable.GetEnumerator();
            bool flag=myEnumerator.MoveNext();
            while (flag)
            {
                Console.WriteLine("键+"+myEnumerator.Key+"值："+myEnumerator.Value);
                flag= myEnumerator.MoveNext();
            }
            #endregion
            #region 装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时，就存在拆箱
            #endregion

        }
    }
}
