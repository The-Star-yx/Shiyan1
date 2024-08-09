using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    /// <summary>
    /// 绘制类型
    /// </summary>
    enum E_DrawType
    {
        wall,

        Cube,

        Line,

        Tank,

        Left_Ladder,

        Right_Ladder,

        Left_Long_Ladder,

        Right_Long_Ladder,
    }

    class DrawObject : IDraw
    {
        public Position pos;

        public E_DrawType type;

      
        public DrawObject(E_DrawType type, int x, int y) : this(type)
        {
            this.pos= new Position(x,y);
        }

        public DrawObject(E_DrawType type)
        {
            this.type = type;
        }

        public void Draw()
        {
            if (pos.y < 0)
                return;
            Console.SetCursorPosition(pos.x, pos.y);

            switch(type)
            {
                    case E_DrawType.wall:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;              
                    case E_DrawType.Cube:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                    case E_DrawType.Line:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                    case E_DrawType.Tank: 
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                    case E_DrawType.Left_Ladder:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                    case E_DrawType.Right_Ladder:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                    case E_DrawType.Left_Long_Ladder:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                    case E_DrawType.Right_Long_Ladder: 
                    Console.ForegroundColor= ConsoleColor.White;
                    break;                   
            }
            Console.Write("■");
        }

        //清除绘制的方法
        public void ClearDraw()
        {
            if (pos.y < 0)
                return;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write("  ");
        }

        /// <summary>
        /// 切换方块类型 用于下落到地铁时 把板砖类型变成地图类型
        /// </summary>
        /// <param name="type"></param>
        public void ChangeType(E_DrawType type)
        {
             this.type= type;
        }
    }
}
