using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace 泛型约束练习
{
    //用泛型实现一个单例模式基类
    class SingleBase<T>where T:new()
    {
        private static T instance=new T();

        public static T Instance
        {
            get { return instance; }
        }
    }
    class GameMGr:SingleBase<GameMGr>
    {
        public int value = 10;        
    }
    class Test2:SingleBase<Test2>
    {
        public int value = 10;
    }


    //普通单例模式
    class Test
    {
        private static Test instance=new Test();
        public int value = 10;

        private Test() { }  

        public static Test Instance
        {
            get { return instance; }

        }
    }


    class ArrayList<T>
    {
        private T[] array;
        
        public ArrayList()
        {
            count = 0;
            array = new T[16];
        }

        private int count;
        public int Capcity
        {
            get { return array.Length; }
        }
        public int Count
        {
            get { return count;}
        }
        public void Addd(T value)
        {
            if(count>=Capcity)
            {
                T[] temp = new T[Capcity * 2];
                for(int i = 0; i < Capcity; i++)
                {
                    temp[i] = array[i];
                }
                array = temp;
            }
            array[count] = value;
            ++count;
        }
        public void Remove(T value)
        {
            int index = -1;
            for(int i = 0;i<Count;i++)
            {
                if (array[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            if(index!=-1)
            {
                RemoveAt(index); 
            }
        }
        public void RemoveAt(int index)
        {
            //索引是否合法
            if(index<0||index>=Count)
            {
                Console.WriteLine("索引不合法");
                return;
            }
           
                for (; index < Count - 1; index++)
                {
                    array[index] = array[index + 1];
                }
                //把一个数移除 后面的往前放 最后一个移除
                array[Count - 1] = default(T);
                --count;
            
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("索引不合法");
                    return default(T);
                }
                return array[index]; 
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("索引不合法");
                    return;
                }
               
                array[index] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            Test.Instance.value = 10;

            GameMGr.Instance.value = 1;
            Test2.Instance.value = 2;

            ArrayList<int> array = new ArrayList<int>();
            Console.WriteLine(array.Count);
            Console.WriteLine(array.Capcity);
            array.Addd(1);
            array.Addd(2);
            Console.WriteLine(array.Count);
            Console.WriteLine(array.Capcity);

            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);

            array.Remove(2);
            Console.WriteLine(array.Count);
            Console.ReadKey();
        }
    }
}
