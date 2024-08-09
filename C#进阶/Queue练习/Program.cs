using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue queue = new Queue();
            queue.Enqueue("asdf");
            queue.Enqueue("asdf1");
            queue.Enqueue("asdf2");
            queue.Enqueue("asdf3");
            queue.Enqueue("asdf4");
            queue.Enqueue("asdf5");
            queue.Enqueue("asdf6");
            queue.Enqueue("asdf7");
            queue.Enqueue("asdf8");
            queue.Enqueue("asdf9");
            queue.Enqueue("asdf10");

            int updateIndex = 1;
            while(queue.Count>0)
            {
                if(updateIndex%99999999999999999==0)
                {
                    Console.WriteLine(queue.Dequeue());
                    updateIndex = 0;
                }
                ++updateIndex;
            }
            Console.ReadKey();
        }
        static void Cun(string xiaoxi)
        {
            Queue queue=new Queue();
            while(true)
            {
                if(xiaoxi==null)
                {
                    break;
                }
                queue.Enqueue(xiaoxi);
            }
            while(queue.Count > 0)
            {
                object o=queue.Dequeue();
                Console.WriteLine(o);
            }
        }
    }
}
