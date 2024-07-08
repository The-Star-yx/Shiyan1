using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuoYe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("圆的面积是");
            Console.WriteLine(Circule.CirculeArea(2));
            Console.WriteLine("圆的周长是");
            Console.WriteLine(Circule.CircleLength(3));
            Console.WriteLine("矩形的面积是");
            Console.WriteLine(Circule.CalcRectAre(3, 4));
            Console.WriteLine("矩形的周长是");
            Console.WriteLine(Circule.CalcRectLength(3, 4));
            Console.WriteLine("绝对值");
            Console.WriteLine(Circule.ABS(-1));
            Console.ReadKey();
     
        }
    }
}
