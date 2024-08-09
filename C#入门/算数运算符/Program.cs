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
            #region 逻辑运算符
            //符号： &&、||、！、！！           
            //逻辑运算符优先级 低于 条件运算符、算术运算符（逻辑非除外）
            //混合使用规则：！（逻辑非）优先级最高 &&（逻辑与）优先级高于||（逻辑或）

            #endregion
            #region 位运算符
            //1.位于&
            //规则 连接两个数进行位运算 将数值转为2进制
            //对位计算 有0则0
            //多个数值进行位运算 没有括号时 从左到右依次计算
            int a6 = 1;//001
            int b6 = 5;//101
            int c=a6&b6;
            // 001
            //&101
            // 001->1
            Console.WriteLine(c); //c=1

            //2.位或 |
            //规则 连接两个数值进行位运算 将数值转为2进制
            //对位运算 有1则1

            //3.异或 ^
            //规则 连接两个数值进行位运算 将数值转为2进制
            //对位运算 相同为0 不同为1

            //4.位取反~
            //规则 写在数值前面 将数值转为2进制
            //对位运算 0变1 1变0（在补码基础上转换，最后换成原码输出）
            a = 5;//0101
            //0000 0000 0000 0000 0000 0000 0000 0101（原码）
            //0000 0000 0000 0000 0000 0000 0000 0101（补码，因为是正数，原码和补码相同）
            //1111 1111 1111 1111 1111 1111 1111 1010（补码取反）
            //1000 0000 0000 0000 0000 0000 0000 0110（补码转原码，从右往左数第一个1左边数值位全部取反）（第一个是符号位不变）
            //即为-6
            //反码补码知识            
            c = ~a;
            Console.WriteLine(c);//输出-6

            //5.左移 <<
            //5.右移>>
            //规则 让一个数的2进制数进行左移和右移
            //左移几位 右侧加几个0
            //右移几位 右侧去掉几个数
            a = 5; /*101 */     a=5;//101
            c = a << 5;         c = a >> 2;
            //1位 1010          //1位 10
            //2位 10100         //2位 1
            //3位 101000
            //4位 1010000
            //5位 10100000
            Console.WriteLine(c);//输出160

            #endregion
            #region 三目运算符
            //套路：3个空位 2个符号
            //固定语法： 空位1 ？ 空位2：空位3;
            //会有返回值，需要保证空位2、空位3结果类型一致
            //例： 空位1为真->返回空位2
            //     空位1为假->返回空位3

            #endregion
            Console.ReadKey();
        }
    }
}
