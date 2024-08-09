using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    #region 概念
    //让对象可以像数组一样通过索引访问其中元素
    //get和set中可以写逻辑
    //可以重载
    #endregion
    class Person
    {
        private string name;
        private int age;
        private Person[] friends;
        private int[,] array;

        public Person this[int index]
        {
            get
            {
                if(friends == null)
                {
                    return null;
                }
                else if(friends.Length-1<index)
                {
                    return null;
                }
                return friends[index];
            }
            set 
            {
                //value 代表传入的值
                if (friends == null)
                {
                    friends = new Person[] { value };

                }
                else if(index>friends.Length-1)
                {
                    //自己定一个规则 如果索引越界 就默认把最后一个朋友顶掉
                    friends[friends.Length-1] = value;
                }
                friends[index] = value;
            }
        }
        public int this[int i,int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p[0]=new Person();
            Console.WriteLine(p[0]);
            p[0, 0] = 10;
            Console.WriteLine(p[0, 0] );
        }
    }
}
