using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class BlockInfo
    {
        //方块信息坐标的容器
        private List<Position[]> list;

        public BlockInfo(E_DrawType type)
        {
            //必须要初始化才能往里面装东西
            list=new List<Position[]>();

            switch(type)
            {            
                case E_DrawType.Cube:
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(0,1),
                        new Position(2,1)
                    });
                    break;
                case E_DrawType.Line:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(0,1),
                        new Position(0,2)
                        });
                    list.Add(new Position[3]{
                        new Position(-4,0),
                        new Position(-2,0),
                        new Position(2,0)
                        });
                    list.Add(new Position[3]{
                        new Position(0,-2),
                        new Position(0,-1),
                        new Position(0,1)
                        });
                    list.Add(new Position[3]{
                        new Position(-2,0),
                        new Position(2,0),
                        new Position(4,0)
                        });
                    break;
                case E_DrawType.Tank:
                    list.Add(new Position[3] {
                        new Position(-2,0),
                        new Position(2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(-2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(2,0),
                        new Position(0,1)
                    });
                    break;
                case E_DrawType.Left_Ladder:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(2,0),
                        new Position(2,1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(0,1),
                        new Position(-2,1)
                    });
                    list.Add(new Position[3]{
                       new Position(-2,-1),
                        new Position(-2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(2,-1),
                        new Position(-2,0)
                    });
                    break;
                case E_DrawType.Right_Ladder:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(-2,0),
                        new Position(-2,1)
                    });
                    list.Add(new Position[3]{
                        new Position(-2,-1),
                        new Position(0,-1),
                        new Position(2,0)
                    });
                    list.Add(new Position[3]{
                        new Position(2,-1),
                        new Position(2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(0,1),
                        new Position(2,1),
                        new Position(-2,0)
                    });
                    break;
                case E_DrawType.Left_Long_Ladder:
                    list.Add(new Position[3]{
                        new Position(-2,-1),
                        new Position(0,-1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,-1),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(2,1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(-2,0),
                        new Position(-2,1)
                    });
                    break;
                case E_DrawType.Right_Long_Ladder:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(0,1),
                        new Position(2,-1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(-2,0),
                        new Position(2,1)
                    });
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(-2,1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(-2,-1),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    break;
                    default: break;
            }
        }

        /// <summary>
        /// 提供外部根据索引快速获取 位置偏移信息
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Position[] this[int index]
        {
            get
            {
                if (index < 0)
                    return list[0];
                else if (index >= list.Count)
                    return list[list.Count-1];
                else return list[index];
            }
        }

        /// <summary>
        /// 获取给外部形态
        /// </summary>
        public int Count { get=>list.Count; }
    }
}
