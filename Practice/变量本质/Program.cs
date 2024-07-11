using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 变量存储空间
            //1byte=8bit
            //1KB=1024byte
            //1MB=1024KB
            //1GB=1024MB

            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte所占的字节数为："+sbyteSize);
            int intSize=sizeof(int);
            Console.WriteLine("int所占的字节数为：" + intSize);
            int shortSize=sizeof(short);
            Console.WriteLine("short所占的字节数为：" + shortSize);
            int longSize=sizeof(long);
            Console.WriteLine("long所占的字节数为：" + longSize);
            Console.WriteLine("#####################################");

            int byteSize = sizeof(byte);
            Console.WriteLine("byte所占的字节数为：" + byteSize);
            int uintSize = sizeof(uint);
            Console.WriteLine("uint所占的字节数为：" + uintSize);
            int ushortSize = sizeof(ushort);
            Console.WriteLine("ushort所占的字节数为：" + ushortSize);
            int ulongSize = sizeof(ulong);
            Console.WriteLine("ulong所占的字节数为：" + ulongSize);
            Console.WriteLine("#####################################");

            int floatSize = sizeof(float);
            Console.WriteLine("float所占的字节数为：" + floatSize);
            int doubleSize = sizeof(double);
            Console.WriteLine("double所占的字节数为：" + doubleSize);
            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal所占的字节数为：" + decimalSize);            
            Console.WriteLine("#####################################");

            int boolSize = sizeof(bool);
            Console.WriteLine("bool所占的字节数为：" + boolSize);
            int charSize = sizeof(char);
            Console.WriteLine("char所占的字节数为：" + charSize);                     
            Console.WriteLine("#####################################");
            Console.ReadKey();
            #endregion
            #region 变量本质
            //变量的本质是2进制->计算机中所有数据的本质都是二进制
            #endregion
        }
    }
}
