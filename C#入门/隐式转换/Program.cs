using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 隐式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //隐式转换规则 大范围装小范围
            #region 相同大类型的转换
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte b = 1;

            uint u = 1;
            ulong v = 1;
            ushort w = 1;
            byte x = 1;

            double y = 1;
            float z = 1;
            decimal da= 1m;

            char c = 'A';

            //有符号 int->long
            l = i;

            //无符号 ushort->uint
            u = w;
            

            //浮点数 
            //decimal无法用隐式转换来存储double float
            //浮点数 float->double
            y = z;

            //特殊类型无
            #endregion
            #region 不同大类型之间转换
            //无符号和有符号
            //无符号装有符号不存在
            //有符号装有符号 需要注意范围限制
            i = w;

            //浮点数 可以装任何类型整数
            z = l;
            //decimal 不能隐式存储double float但可以存储整形

            //整数装浮点数不存在

            //特殊类型均不存在 char类型除外
            //char类型可以隐式转换成整形或浮点型 转换完是ASCII码
            i= c;

            //总结
            //double->float->整数（无符号、有符号）->char
            //decimal->整数（无符号、有符号）->char
            //long->int->short->sbyte
            //ulong->uint->ushort->byte
            //无符号 没法 隐式存储 有符号
            //有符号 可以 隐式存储 无符号 但需要注意范围大小
            #endregion
        }
    }
}
