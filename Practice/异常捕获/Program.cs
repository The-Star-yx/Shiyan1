using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作用
            //将玩家输入的内容 存储 string类型的变量（容器)中
            //可以避免代码报错时 造成程序卡死
            string str=Console.ReadLine();
            int i =int.Parse(str);
            #endregion
            #region 语法
            //必备部分
            try
            {
                //希望进行异常捕获的代码块放到这里
                //如果try中代码报错不会卡死
            }
            catch
            {
               //如果出错 会执行catch中代码 捕获异常 
               //catch(Exception e)具体报错跟踪 通过e得到
            }
            //可选部分
            finally
            {
                //最后执行代码 不管有没有出错 都会执行其中的代码

            }
            
            
            #endregion
            Console.ReadKey();
        }
    }
}
