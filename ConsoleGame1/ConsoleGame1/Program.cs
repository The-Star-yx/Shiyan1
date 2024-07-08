using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
                                       
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();      //改变字体颜色
            Console.CursorVisible = false;                          //光标隐藏
            int x = 1, y = 1;
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                //得到输入信息
                char c = Console.ReadKey(true).KeyChar;
                //把之前方块擦除
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                switch (c)
                {
                    case 'W':
                    case 'w':
                        y -= 1;
                        //改变位置过后  判断新位置 是否越界
                        if (y < 0)
                        {
                            y = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        //得到缓冲区大小
                        if (y > Console.BufferHeight - 1)//图形高为1
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'A':
                    case 'a':
                        x -= 2;//中文符号在控制台占两个字符
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if (x > Console.BufferWidth - 2)//图像宽为2
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;
                }
            }
        }
    }
}
