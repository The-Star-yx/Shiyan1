using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    #region 概念
    //被命名的整形常量的集合
    //一般用来表示 状态 类型等

    //申明枚举
    //enum E_自定义枚举名(E或E_开头 作为命名规范）
    //1.namespace语句块中
    //2.class语句块中 struct语句块中
    //注意：不能在函数语句块中申明

    //enum E_自定义;
    //{
    //    自定义枚举项名字,     枚举中包裹的整形常量 第一个默认值为0  下面会依次累加
    //    自定义枚举项名字2,
    //    自定义枚举项名字3,
    //}

    enum E_MonsterType
    {
        Noramal,//0

        Boss,//1
    }

    enum E_PlayerType
    {
        Main,

        Other,

    }   

    #endregion
    internal class Program
    {

        static void Main(string[] args)        
        {
            #region 枚举使用
            //申明枚举变量(实例化）
            E_PlayerType playerType = E_PlayerType.Main;

            if(playerType == E_PlayerType.Main)
            {
                Console.WriteLine("主玩家逻辑");
            }
            else if(playerType == E_PlayerType.Other)
            {
                Console.WriteLine("其它玩家逻辑");
            }

            //枚举和switch天生一对
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch(monsterType)
            {

                case E_MonsterType.Noramal:
                    break;
                    case E_MonsterType.Boss:
                    break;
                    default:
                    break;

            }
            #endregion
            #region 枚举类型转换
            //1.枚举和int互转
            int i = (int)playerType;
            Console.WriteLine(i);

            //2.枚举和string互转
            string str=playerType.ToString();
            Console.WriteLine(str);

            //把string转成枚举
            playerType = (E_PlayerType)Enum.Parse(typeof(E_MonsterType), "Other");
            Console.WriteLine(playerType);
            #endregion
            #region 枚举总结
            //在游戏开发中，对象很多时候 会有许多状态
            //枚举可以帮助我们清晰的分清楚状态的含义
            #endregion
            Console.ReadKey();
        }
    }
}
