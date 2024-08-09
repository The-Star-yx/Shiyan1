using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
     class Map:IDraw
    {
        //固定墙壁
        private List<DrawObject> walls = new List<DrawObject>();

        //动态墙壁
        public List<DrawObject> dynamicWalls= new List<DrawObject>();

        //动态墙壁的宽容器 一行可以有多少个
        public int w;
        public int h;

        //记录每一行有多少个小方块的容器
        //索引对应的就是行号
        private int[] recordInfo;

        private GameScene nowGameScene;

        public Map(GameScene scene)
        {
            this.nowGameScene = scene;
            //为了方便外部得到地图的高的边界
            h = Game.h - 6;
            //代表对应每行的计数初始化
            recordInfo = new int[h];

            w = 0;
            //绘制横向固定墙壁
            for (int i = 0; i < Game.w; i += 2)
            {
                walls.Add(new DrawObject(E_DrawType.wall, i, h));
                ++w;
            }
            w -= 2;

            for (int i = 0; i < h; i++)
            {
                walls.Add(new DrawObject(E_DrawType.wall, 0, i));
                walls.Add(new DrawObject(E_DrawType.wall, Game.w - 2, i));
            }

            //this.nowGameScene = nowGameScene;
        }

        public void Draw()
        {
            //绘制固定墙壁
            for(int i=0;i<walls.Count;i++)
            {
                walls[i].Draw();
            }
            //绘制动态墙壁
            for (int i=0; i<dynamicWalls.Count;i++)
            {
                dynamicWalls[i].Draw();
            }
        }

        //清楚动态墙壁
        public void ClearDraw()
        {
            for (int i = 0; i < dynamicWalls.Count; i++)
            {
                dynamicWalls[i].ClearDraw();
            }
        }


        public void AddWalls(List<DrawObject> walls)
        {
            for (int i = 0; i < walls.Count; i++)
            {
                //传递方块进来时 把其类型改为 墙壁类型
                walls[i].ChangeType(E_DrawType.wall);
                dynamicWalls.Add(walls[i]);

                //动态墙壁添加处 发现 位置满了 就结束
                if (walls[i].pos.y<=0)
                {
                    //关闭输入线程
                    this.nowGameScene.StopThread();
                    //场景切换 切换到结束界面
                    Game.ChangeScene(E_SceneType.End);
                    return;
                }
                //进行动态墙壁的计数
                recordInfo[h - 1 - walls[i].pos.y ]+= 1;
            }

            //先把之前的动态小方块擦掉
            ClearDraw();
            //检测移除
            CheckClear();
            //再绘制
            Draw();
        }

        /// <summary>
        /// 检测是否跨层
        /// </summary>
        public void CheckClear()
        {
            List<DrawObject> delist= new List<DrawObject>();    
            for(int i = 0;i<recordInfo.Length;i++)
            {
                //必须满足条件 才证明满了
                //小方块计数==w（这个w已经是去掉了左右两边的固定墙壁）
                if (recordInfo[i]==w)
                {
                    //1.这一行的所有小方块移除
                    for(int j=0;j<dynamicWalls.Count;j++)
                    {
                        //通过动态方块的y计算它在哪一行 如果行号和当前记录索引一致 就证明 可以移除
                        if (j == h-1 - dynamicWalls[j].pos.y-1)
                        {
                            //移除这个方块 为了安全移除 添加一个表
                            delist.Add(dynamicWalls[j]);
                        }
                        //2.要这一行之上的所有小方块下移一个单位
                        //如果当前这个位置 是该行以上 那就该小方块 下移一格
                        else if(h - 1 - dynamicWalls[j].pos.y - 1>i)
                        {
                            ++dynamicWalls[j].pos.y;
                        }
                    }
                    //移除待删除的小方块
                    for(int j=0;j<delist.Count;j++)
                    {
                        dynamicWalls.Remove(delist[j]);
                    }
                    //3.记录小方块数量的数组从上到下迁移
                    for(int j=i;j<recordInfo.Length-1;j++)
                    {
                        recordInfo[j] = recordInfo[j + 1];
                    }
                    //置空最顶的计数
                    recordInfo[recordInfo.Length - 1] = 0;

                    //空掉一行后 再去执行从头检测是否跨层
                    CheckClear();
                    break;
                }
                
            }
        }
    }
}
