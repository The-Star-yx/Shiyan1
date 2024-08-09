using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 核心练习题
{
    #region 1
    public static class Person
    {
        public static string name;
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static void P(string name)
        {
            Console.WriteLine(name);

        }
    }
    public class Vector3
    {
        public int x, y, z;
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 v = new Vector3();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 v = new Vector3();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }
        public static Vector3 operator *(Vector3 v1, int num)
        {
            Vector3 v = new Vector3();
            v.x = v1.x * num;
            v.y = v1.y * num;
            v.z = v1.z * num;


            return v;
        }
    }
    struct Position
    {
        public int x;
        public int y;

        public static bool operator ==(Position x1, Position y1)
        {
            if (x1.x == y1.x && x1.y == y1.y)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Position x1, Position y1)
        {
            if (x1.x == y1.x && x1.y == y1.y)
            {
                return false;
            }

            return true;
        }
    }
    #endregion
    #region 2
    public class Monster
    {

    }
    public class Boss : Monster
    {



        public void Boss_Atk()
        {
            Console.WriteLine("释放技能");
        }

    }
    public class Goblin : Monster
    {
        public void Goblin_Atk()
        {
            Console.WriteLine("攻击");
        }
    }
    #endregion
    #region 3
    public class Player
    {
        private Weapen nowHaveWeapon;
        public Player()
        {
            nowHaveWeapon = new Knife();
        }   
        public void Pickup(Weapen weapen)
        {
            nowHaveWeapon=weapen;
        }
    }
    public class Weapen : Player
    {

    }
    public class ChongFeng : Weapen
    {
        public void ChongFeng_Atk()
        {
           
        }
    }
    public class SanDan : Weapen
    {
        public void SanDan_Atk()
        {
           
        }
       
    }
    public class ShouQiang : Weapen
    {
        public void ShouQiang_Atk()
        {
          
        }
    }
    public class Knife : Weapen
    {
        public void Knife_Atk()
        {
           
        }
    }
    #endregion
    #region 4
    abstract class Animal
    {
        public abstract void Speak();
    }
    class Person0 : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("人说话");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Position x1;
            //x1.x = 1;
            //x1.y = 1;

            //Position y1;
            //y1.x = 1;
            //y1.y = 1;

            //if (x1 == y1)
            //{
            //    Console.WriteLine("相等");
            //}

            //Vector3 v1 = new Vector3();
            //v1.x = 1;
            //v1.y = 1;
            //v1.z = 1;

            //Vector3 v2 = new Vector3();
            //v2.x = 1;
            //v2.y = 1;
            //v2.z = 1;

            //Vector3 v3 = v1 + v2;
            //Console.WriteLine("{0}|{1}|{2}", v3.x, v3.y, v3.z);


            //Person.P("sdf");
            //Console.ReadKey();
            #endregion
            #region 2
            //Monster[] monsters=new Monster[10];

            //Random a = new Random();
            //int randomNum;
            //for(int i=0;i<monsters.Length;i++)
            //{
            //    randomNum=a.Next(0,100);
            //    if(randomNum<50)
            //    {
            //        monsters[i]= new Boss();
            //    }
            //    else
            //    {
            //        monsters[i]=new Goblin();
            //    }
            //}
            //for(int i=0;i<monsters.Length;i++)
            //{
            //    if (monsters[i] is Boss)
            //    {
            //        (monsters[i] as Boss).Boss_Atk();
            //    }
            //    else if (monsters[i] is Goblin)
            //    {
            //        (monsters[i] as Goblin).Goblin_Atk();
            //    }
            //}
            //Console.ReadKey();
            #endregion
            #region 3
            //Player player = new Player();

            //ChongFeng cheng = new ChongFeng();
            //cheng.Pickup(cheng);

            //SanDan san = new SanDan();
            //san.Pickup(san);
            #endregion
            #region 4
            Animal a = new Person0();
            a.Speak ();
            #endregion



        }
    }
}
