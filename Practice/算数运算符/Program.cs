using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 赋值符号
            //将右侧值赋值给左侧
            #endregion
            #region 算术运算符
            //+ - * \ % 

            #endregion
            #region 字符串拼接1 
            //只有+= + 
            string str = "123";
            str = str + "456";
            Console.WriteLine(str);

            str = "";
            str += 1 + 2 + 3 + "" + 4;
            Console.WriteLine(str);
            #endregion
            #region 字符串拼接2
            //固定语法
            //string.Format("待拼接的内容",内容1，内容2...)
            string str1=string.Format("我是{0},我今年{1}岁，我想要{2}", "小玺", "20", "你");
            Console.WriteLine(str1);
            #endregion
            #region 控制台拼接
            Console.WriteLine("A{0}B{1}", "1", "2");
            #endregion
            #region 条件运算符           
            //  > < == != >= <=
            int a = 0;
            int b = 1;
            bool result = a< b;
            Console.WriteLine(result);
            #region 不同类型之间比较
            //可以随意进行条件运算符比较
            //特殊类型 char string bool 只能同类型进行==和！=比较
            #endregion

            #endregion
            Console.ReadKey();
        }
    }
}
