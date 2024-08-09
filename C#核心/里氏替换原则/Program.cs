using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏替换原则
{
    #region 概念
    //是面向对象七大原则中最重要的原则
    //
    //任何父类出现的地方，子类都可以替代

    //重点：
    //语法表现——父类容器装子类对象，因为子类对象包含了父类的所有内容
    //
    //作用：方便进行对象存储和管理

    #endregion
    class GameObject
    {
        public void Atk ()
        {
            Console.WriteLine("玩家攻击");
        }
    }
    class Player:GameObject
    {
        public void PlayerAtk()
        {
            Console.WriteLine("玩家攻击");
        }
    }
    class Monster:GameObject
    {
        public void MonsterAtk()
        {
            Console.WriteLine("怪兽攻击");
        }
    }
    class Boss : GameObject
    {
        public void BossAtk()
        {
            Console.WriteLine("Boss攻击");
        }
    }
    #region is和as
    //概念
    //is：判断一个对象是否为指定类对象
    //返回值：bool 是为真 不是为假

    //as：将一个对象转换为指定类对象
    //返回值：指定类型对象
    //成功返回执行类型对象，失败返回null

    //基本语法
    //类对象 is 类名 该语句块 会有一个bool返回值 true和false
    //类对象 as 类名 该语句块 会有一个对象返回值 对象和null
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //用父类容器 装载子类对象
            GameObject player=new Player();
            GameObject monster=new Monster();
            GameObject boss=new Boss();

            GameObject[] objects = new GameObject[] { new Player(), new Monster(), new Boss() };

            if (player is Player)
            {
                Player p=player as Player;
                p.PlayerAtk();

                (player as Player).PlayerAtk();
            }
            for(int i = 0; i < objects.Length; i++)
            {
                if (objects[i] is Player)
                {
                    (player as Player).PlayerAtk();
                }
                else if (objects[i] is Monster)
                {
                    (monster as Monster).MonsterAtk();
                }
                else if (objects[i] is Boss)
                {
                    (boss as Boss).BossAtk();
                }
            }
        }
    }
}
