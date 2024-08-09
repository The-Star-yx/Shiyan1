using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托练习
{
    

    abstract class Person
    {
        public abstract void Eat();
    }
    class Monther : Person
    {
        public Action beginEat;
        public override void Eat()
        {
            Console.WriteLine("妈妈吃饭");
        }
        public void DoFood()
        {
            Console.WriteLine("妈妈做饭");

            Console.WriteLine("饭做好了");

            beginEat();
        }
    }
    class Father : Person
    {
        public override void Eat()
        {
            Console.WriteLine("爸爸吃饭");
        }
    }
    class Son : Person
    {
        public override void Eat()
        {
            Console.WriteLine("儿子吃饭");
        }
    }


    class Monster
    {
        public Action<Monster> deadDoSomthing;

        public int money = 10;
        public void Dead()
        {
            Console.WriteLine("怪物死亡");
            if(deadDoSomthing!= null)
            {
                deadDoSomthing(this);
            }
            //一般情况下 委托关联的函数 有加就有减 （或者直接清空）
            deadDoSomthing = null;
        }
    }
    class Chengjiu
    {
        private int NowKillMonsterNum = 0;

        public void MonsterDeadSomthing(Monster m)
        {
            NowKillMonsterNum += 1;
            Console.WriteLine("现在有" + NowKillMonsterNum);
        }
    }
    class Player
    {
        public int myMoney=0;
        public void MonsterDeadSomthing(Monster m)
        {
            myMoney += m.money;
            Console.WriteLine("现在有"+myMoney);
        }
    }
    class Panel
    {
        private int nowShowMoney = 0;

        public void MonsterDead(Monster m)
        {
            nowShowMoney += m.money;
            Console.WriteLine("当前面板" + nowShowMoney  );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Monther m=new Monther();
            //Father n=new Father();
            //Son son=new Son();

            //m.beginEat += n.Eat;
            //m.beginEat += son.Eat;
            //m.beginEat += m.Eat;

            //m.DoFood();

            Monster monster = new Monster();
            Player p= new Player();
            Panel p2 = new Panel();
            Chengjiu chengjiu = new Chengjiu();

            monster.deadDoSomthing += p.MonsterDeadSomthing;
            monster.deadDoSomthing += p2.MonsterDead;
            monster.deadDoSomthing += chengjiu.MonsterDeadSomthing;

            monster.Dead();

            Console.ReadKey();
        }
       
    }
    
}
