using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 显式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 括号强转
            //作用：一般情况下 将高精度的类型强制转换为低精度
            //语法：变量类型 变量名=（变量类型）变量
            //注意： 精度问题 范围问题

            //相同大类的整形
            //有符号整形
            sbyte sb = 1;
            short s = 1;
            int i=1;
            long l = 1;

            //括号强转 可能会出现范围问题造成的异常
            s=(short)i;
            Console.WriteLine(s);

            //无符号整形
            byte b = 1;
            ushort ss = 1;
            uint ui = 1;
            ss = (byte)ui;
            b=(byte)ss;

            //浮点
            float f = 1.1f;
            double db = 1.123456789f;
            f=(float)db;

            //无符号和有符号
            uint ui2 = 1;
            int i2 = -1;
            ui2=(uint)i2;

            //浮点和整形 会直接抛弃掉小数点后的数值
            float f1 = 1.2f;
            int i1 = -1;
            f1=(float)i1;

            //char和数值类型
            char c= 'a';
            char a=(char)c;
            Console.WriteLine(a);
            

            //bool和string 不能够通过括号强转


            #endregion
            #region Parse法
            //作用： 把字符串类型转换为对应类型
            //语法 变量类型.Parse（"字符串")
            //注意 字符串必须能够转换成对应类型 否则报错

            //有符号
            int i4 = int.Parse("1234");
            Console.WriteLine(i4);
            Console.WriteLine(int.Parse("1234"));

            //无符号
            Console.WriteLine(uint.Parse("1"));

            //浮点
            Console.WriteLine(float.Parse("1.1"));

            //特殊类型
            Console.WriteLine(bool.Parse("true"));

            #endregion
            #region Convert法
            //作用：更准确的将 各个类型之间相互转换
            //语法：Convert.To目标类型（变量或常量）
            //注意 填写的变量或常量必须正确

            //转字符串 精度比括号好一点 会四舍五入
            int a1 = Convert.ToInt32("12");
            Console.WriteLine(a1);
            a1 = Convert.ToInt32(1.23f);
            Console.WriteLine(a1);

            sbyte sb1=Convert.ToSByte("1");
            short s14 = Convert.ToInt16("1");
            int s3 = Convert.ToInt32("1");
            long l3=Convert.ToInt64("1");

            byte k2=Convert.ToByte("1");
            ushort l4=Convert.ToUInt16("1");
            ulong l5=Convert.ToUInt64("1");
            uint l2=Convert.ToUInt32("1");

            float f3=Convert.ToSingle("12.1");
            double d3 = Convert.ToDouble("12.1");
            decimal de3 = Convert.ToDecimal("12.5");

            bool bo1=Convert.ToBoolean("1");
            char bo2=Convert.ToChar("1");
            string bo3=Convert.ToString("1");
            #endregion
            #region 其他类型转string
            //作用：拼接打印
            //语法：变量.tostring()

            string st1=1.ToString();
            st1=true.ToString();
            //等等都能用

            //当我们进行字符串拼接时 会自动调用tostring
            Console.WriteLine("1234"+1+b );
            #endregion
            Console.ReadKey();
        }
    }
}
