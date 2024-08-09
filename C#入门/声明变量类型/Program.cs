using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 声明变量类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 声明变量类型
            //1.有符号的整形变量 是能存储 正负数包括0的变量类型
            //sbyte -128~127
            //int   -21亿~21亿多
            //short -32758~32767之间的数
            //long  -9百万兆~9百万兆

            //sbyte sb = 127;
            //Console.WriteLine("sbyte变量sb中存储的值是：" + sb);
            //Console.ReadKey();

            //2.无符号的整形变量 能存储 一定范围 0和正数的变量类型
            //byte 0~255
            //uint 0~42亿多
            //ushort 0~65535
            //ulong 0~18百万兆

            //3.浮点数（小数）
            //float 存储7/ 8位有效数字 根据编译器不同 有效数字不同
            //C#中声明小数是默认double
            //float f = 0.1234567890f;
            //Console.WriteLine(f);
            //Console.ReadKey();
            ////double 存储15~17位
            //double d = 0.1234567890;
            ////decimal 存储27~28位有效数字
            //decimal de = 0.12345678m;

            //4.特殊类型
            //bool
            //bool bo = true;
            //Console.WriteLine(bo);
            ////char 存储单个字符变量类型
            //char c = 'A';
            //Console.WriteLine(c);
            ////string 字符串类型 用来存储多个字符 无上限
            //string str = "woshi";
            //Console.WriteLine(str);

            //string a = "男";
            //string b = "女";
            //Console.WriteLine(b);
            //Console.ReadKey();
            //#endregion
        }
    }
}
