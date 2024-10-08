﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程
{
    internal class Program
    {
        static bool isRuning = true;
        static object obj=new object();
        static void Main(string[] args)
        {
            #region 进程
            //进程（Process）是计算机中的程序关于某数据集合上的一次运行活动，是系统进行
            //资源分配和调度的基本单位，是操作系统结构的基础
            //进程之间可以相互运行，互不干扰
            //进程之间也可以相互访问、操作
            #endregion
            #region 线程
            //操作系统能够进行运算调度的最小单位
            //它被包含在进程之中，是进程中的实际运作单位
            //一条线程指的是进程中一个单一顺序的控制流，一个进程中可以并发多个线程
            //我们目前所写的程序 都在主线程中

            //代码从上到下运行的一条“管道”

            //多线程：
            //可以通过代码 开启新的线程
            //可以同时运行代码的多条“管道”就叫多线程
            //可以用多线程专门处理一些复杂耗时的逻辑
          
          
            #endregion
            #region 语法使用
            //线程类 Thread
            //需要引用命名空间 using System.Threading；

            //1.申明一个新的线程
            //注意 线程执行的代码 需要封装到一个函数中
            //新线程 将要执行的代码逻辑 被封装到了一个函数语句块中
            Thread t=new Thread(NewThreadLogic);

            //2.启动线程
            t.Start();

            //3.设置为后台线程
            //当前台线程都结束了的时候，整个程序也就结束了，即使还有后台线程正在运行
            //后台线程不会防止应用程序的进程被终止掉
            //如果不设置为后台线程 可能导致进程无法正常关闭
            t.IsBackground = true;

            //4.关闭释放一个线程
            //如果开启的线程中不是死循环 是能够结束的逻辑 那么 不用刻意的去关闭它
            //如果是死循环 想要中止这个进程 有两种方式
            //4.1死循环中加入bool标识
            isRuning=false;
            //4.2通过线程提供的方法（在.Net core 版本中无法中止 会报错）
            //中止线程
            try
            {
                t.Abort();
                t = null;
            }
            catch (Exception ex)
            {

            }

            //5.线程休眠
            //让线程休眠多少毫秒 1s=1000毫秒
            //让哪个线程里执行 就休眠哪个线程
            //Thread.Sleep();
            #endregion
            #region 线程之间共享数据
            //线程之间共享数据
            //多个线程使用的内存是共享的，都属于该应用程序（进程）
            //所以要注意 当多线程 同时操作同一片内存区域时可能会出问题
            //可以通过加锁的形式避免问题

            //lock
            //当我们在多个线程中想要访问同样的东西 进行逻辑处理时
            //为了避免不必要的逻辑顺序执行的查错
            //lock（引用类型对象）
            while (true)
            {
                lock(obj)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚪");
                }
               
            }

            
            #endregion
        }
        static void NewThreadLogic()
        {
            while (isRuning)
            {
                //新开线程 执行的代码逻辑
                Thread.Sleep(1000);
                Console.WriteLine("新开代码逻辑");

                lock (obj)
                {
                    Console.SetCursorPosition(10, 5);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("㊣");
                }
                
                
            }
            
        }
    }
}
