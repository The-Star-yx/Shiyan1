using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            char a = '小';
            char b = '玺';
            Console.WriteLine(a + b);         
            #endregion
            #region 2
            Console.WriteLine("输入数学成绩");            
            //int grade_Math = int.Parse(Console.ReadLine()); 
            int grade_Math=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(grade_Math);
            #endregion
            #region 3
            Console.WriteLine("请输入你的年龄");
            try
            {
                int age=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(age);
            }
            catch 
            {
                Console.WriteLine("输入的年龄有误");
            }
            #endregion
            #region 4
            int a2= 99;
            int b4 = 87;
            int change;
            change = b4;
            b4 = a2;
            a2 = change;
            Console.WriteLine(a2);
            Console.WriteLine(b4);
            #endregion
            Console.ReadKey();
        }
    }
}
