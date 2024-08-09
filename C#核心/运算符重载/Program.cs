using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符重载
{
    #region 概念
    //让自定义类和结构体能够使用运算符

    //使用关键字 operator

    //特点
    //1.一定是一个公共的静态方法
    //2.返回值写在operator前
    //3.逻辑处理自定义

    //作用
    //让自定义类和结构体对象可以进行运算
    //注意
    //1.条件运算符需要成对实现
    //2.一个符号可以多个重载
    //3.不能使用ref和out
    #endregion
    #region 可重载和不可重载运算符

    //算术运算符
    //operator -
    //operator +
    //operator *
    //operator /
    //operaror %

    //逻辑运算符
    //operator ！

    //位运算符
    //operator |
    //operator &
    //operator ^
    //operator ~
    //operator <<
    //operaror >>

    //条件运算符
    //1.返回值一般是bool类 也可以是其他的
    //2.相关符号必须配对实现
    //operator >
    //operator <

    //operator >=
    //operator <=

    //operator ==
    //operaror !=

    //逻辑与（&&）逻辑或（||）
    //索引符【】
    //强转运算符（）
    //特殊运算符
    //点. 三目运算符？ ： 赋值符号=

    #endregion
    class Point
    {
        public int x;
        public int y;
        public static Point operator +(Point p1, Point p2)
        {
            Point p = new Point();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            return p;

        }
        public static Point operator +(Point p1, int p2)
        {
            Point p = new Point();
            p.x = p1.x + p2;
            p.y=p1.y + p2;
            return p;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p=new Point();
            p.x = 1;
            p.y = 1;
            Point p2 = new Point();
            p2.x = 2;
            p2.y = 2;

            Point p3 = p + p2;
            Console.WriteLine(p3);
                               
            Point p5=p+3;  
            Console.ReadKey();
        }
    }
}
