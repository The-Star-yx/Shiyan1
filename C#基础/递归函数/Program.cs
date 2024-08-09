using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归函数
{
    internal class Program
    { 
        //函数自己调用自己
        //1.必须有结束调用的条件
        //2.用于条件判断的这个条件 必须改变 能够达到停止的目的
        static void Fun()
        {
            if(false)
            {
                return;
            }
            Fun();
        }
        static void Fun2(int a)
        {
            if(a>10)
            {
                return;
            }
            Console.WriteLine(a);
            a++;
            Fun2(a);
        }

        static void Main(string[] args)
        {

            Fun2(0);
            Console.ReadKey();
        }
    }
}
