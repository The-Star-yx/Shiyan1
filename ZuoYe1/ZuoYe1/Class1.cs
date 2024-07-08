using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZuoYe1
{
    public class Circule
    {
        public static float PI = 3.14f;
        public static float CirculeArea(float r)//求圆形的面积
        {
            return PI * r * r;
        }
        public static float CircleLength(float r)//求圆形的周长
        {
            return 2 * PI * r;

        }
        public static float CalcRectAre(float w, float h)//求矩形的面积
        {

            return w * h;
        }
        public static float CalcRectLength(float w, float h)//求矩形的周长
        { return (w + h) * 2; }


        public static float ABS(float value)//求绝对值
        {
            if (value < 0)
            {
                return -value;
            }
            return value;

        }
    }

}

