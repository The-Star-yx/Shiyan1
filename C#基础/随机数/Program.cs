using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //固定写法
            //Random 随机数变量名 =new Random（）；
            Random random = new Random();

            int i = random.Next();//生成一个非负数的随机数
            Console.WriteLine(i);

            i = random.Next(100);//生成一个0-99的随机数 左边始终是0 左包含
            //右边是100 右不包含

            i=random.Next(5,100);//5-99左包含 右不包含
        }
    }
}
