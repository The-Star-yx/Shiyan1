using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 条件语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if语句
            int a = 10;
            if (a >= 10)
            {
                Console.WriteLine("a大于10");
            }
            else if (a > 5 && a < 10)
            {
                Console.WriteLine("a在6和9之间");
            }
            else
            {
                Console.WriteLine("a小于0");
            }
            #endregion
            #region switch语句
            switch (a)
            {
                    case 0:a++;
                    break;
                    case 1: a--; 
                    break;
                    default: Console.WriteLine("都不输出");
                    break;
            }

            //可以贯穿
            switch (a)
            {
                case 0:                   
                case 1:
                    a--;
                    break;
                default:
                    Console.WriteLine("都不输出");
                    break;
            }
            #endregion
            #region while语句
            while(a>2)//这里括号里只能填bool类型
            {
                Console.WriteLine("请继续输入");
                a++;
            }

            //可以嵌套
            //注意break continue使用范围
            #endregion
            #region dowhile
            do
            {

            } while (a > 0);
            #endregion
            #region for
            for(int i=0;i<10;i++)
            {
                Console.WriteLine();
            }
            #endregion

        }
    }
}
