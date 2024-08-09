using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 转义字符的使用
            //它是字符串的一部分 在字符串中表现单引号 引号 空行等
            //用来识别后面的符号

            //单引号
            string str = "\'哈哈哈\'";
            Console.WriteLine(str);            

            //双引号
            str = "\"哈哈哈\"";
            Console.WriteLine(str);

            //换行
            str = "123\n123";
            Console.WriteLine(str);

            //斜杠 \\ 计算机路径
            str = "哈\\哈哈";
            Console.WriteLine(str);
          
            //制表符（空一个tab键）
            str = "哈\t哈哈";
            Console.WriteLine(str);

            //光标退格
            str = "123\b123";
            Console.WriteLine(str);

            //空字符
            str = "1234\0123";
            Console.WriteLine(str);

            //警报音
            str = "\a";
            Console.WriteLine(str);

            Console.WriteLine("1234\n1234\a1234\t1234\'哈\'\n\"哈哈\"\n");
            Console.ReadKey();

            #endregion
            #region 取消转义字符
            string str2 = @"哈哈\n哈哈";
            Console.WriteLine(str2);
            #endregion
        }
    }
}
