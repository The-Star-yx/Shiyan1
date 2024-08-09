using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace 俄罗斯方块
{
    class GameScene : ISceneUpdate
    {
        Map map;
        BlockWorker blockWorker;

        //bool isRunning;

        //Thread inputThread;
     
        public GameScene()
        {
            map= new Map(this);
            blockWorker = new BlockWorker();

            InputThread.Instance.inputEvent += CheckInputThread;

            //isRunning = true;
            //inputThread = new Thread(CheckInputThread);
            ////设置成后台线程 声明周期随主线程决定
            //inputThread.IsBackground = true;
            //inputThread.Start();
        }

        private void CheckInputThread()
        {
            //while(isRunning)
            //{

                if (Console.KeyAvailable)
                {
                    //为了避免影响主线程 在输入后加锁
                    lock (blockWorker)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.LeftArrow:
                                //判断是否能变形
                                if (blockWorker.CanChange(E_Change_Type.Left, map))
                                    blockWorker.Change(E_Change_Type.Left);
                                break;
                            case ConsoleKey.RightArrow:
                                if (blockWorker.CanChange(E_Change_Type.Right, map))
                                    blockWorker.Change(E_Change_Type.Right);
                                break;
                            case ConsoleKey.A:
                                if (blockWorker.CanMoveRL(E_Change_Type.Left, map))
                                    blockWorker.MoveRL(E_Change_Type.Left);
                                break;
                            case ConsoleKey.D:
                                if (blockWorker.CanMoveRL(E_Change_Type.Right, map))
                                    blockWorker.MoveRL(E_Change_Type.Right);
                                break;
                            case ConsoleKey.S:
                                if (blockWorker.CanMove(map))
                                    blockWorker.AutoMove();
                                break;
                        }
                    }

            }
        //}
        }

       public void StopThread()
        {
            //isRunning = false;
            //inputThread = null;
            InputThread.Instance.inputEvent -= CheckInputThread;
        }

        public void Update()
        {
            lock (blockWorker)
            {
                map.Draw();

                blockWorker.Draw();

                if (blockWorker.CanMove(map))
                    blockWorker.AutoMove();
            }
           

            Thread.Sleep(200);


           
        }
    }
}
