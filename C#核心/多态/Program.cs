using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    #region 多态概念
    //字面意思“多种状态”
    //让继承同一父类的子类们 在执行相同方法时有不同的表现（状态）
    //目的：
    //让同一父类的对象 执行行为（方法）有不同的表现
    //解决问题：
    //让同一对象有唯一行为的特征

    //编译时多态—函数重载，开始就写好的
    //运行时多态（vob，抽象函数，接口）
    //v：virtual（虚函数）
    //o：override（重写）
    //b：base（基类）

    //v和o一定是结合使用，来实现多态
    //b是否使用根据实际需求 来保留父类行为
    class Father
    {
        public void SpeakName()
        {
            Console.WriteLine("父类方法");
        }
    }
    class Son:Father
    {
        public new void SpeakName()
        {
            Console.WriteLine("Son方法");
        }
    }
    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
            this.name = name;
        }
        public virtual void Atk()
        {
            Console.WriteLine("游戏对象攻击");
        }
    }
    class Player : GameObject
    {
        public Player(string name):base(name)
        {

        }

        //重写虚函数
        public override void Atk()
        {
            //base作用：
            //代表父类 可以通过base保留父类行为
            Console.WriteLine("玩家对象攻击");
            base.Atk();
        }
    }
    class Monster : GameObject
    {
        public Monster(string name):base(name)
        {
          
        }
        public override void Atk()
        {
            Console.WriteLine("怪兽攻击");
            base.Atk();
        }
    }

    #endregion
    #region 抽象类和抽象方法
    //被抽象关键字abstract修饰的类
    //特点：
    //1.不能被实例化的类（但可以用里氏替换原则）
    //2.可以包含抽象方法 
    //3.继承抽象类必须重写其抽象方法

    //抽象方法
    //用abstract关键字修饰的方法
    //特点：
    //1.只能在抽象类中申明
    //2.没有方法体
    //3.不能是私有的
    //4.继承后必须实现 用override重写(在父类中申明，在子类实现）
    //注意：
    //如何选择普通类还是抽象类
    //不希望被实例化的对象，相对比较抽象的类可以使用抽象类
    //父类中的行为不太需要被实现的，只希望子类去定义具体的规则

    abstract class Thing
    {
        public string name;
        public abstract void Bad();
        public virtual void Test()
        {
            //可以选择是否写逻辑
        }
        
    }
    class Water : Thing
    {
        public override void Bad()
        {

        }
        //虚方法可以由子类选择性实现
        //抽象方法必须要实现
    }
    #endregion
    #region 接口
    //概念：行为的抽象规范
    //关键字：interface

    //申明规范
    //1.不包含成员变量
    //2.只包含方法、属性、索引器、事件
    //3.成员不能被实现
    //4.成员可以不用写访问修饰符，不能是私有的
    //5.接口不能继承类，但是可以继承另一个接口

    //使用规范
    //1.类可以继承多个接口
    //2.类继承接口后，必须实现接口中所有成员

    //特点
    //1.它和类的申明类似
    //2.接口是用来继承的
    //3.接口不能被实例化，但是可以作为容器储存对象
    //4.实现的接口函数，可以加v再在子类重写
    //5.接口也遵循里氏替换原则

    //一句话：接口是抽象行为的基类
    //命名规范 帕斯卡前面加个I

    //接口继承接口时 不需要实现
    //类继承接口时   类自己去实现所有内容

    //当一个类继承两个接口但是接口中存在着同名方法时
    //注意：显示实现接口时 不能写访问修饰符

    interface IFly
    {
         void Fly();
        string Name
        {
            get;
            set;
        }
        int this[int index]
        {
            get;
            set;
        }
        event Action doSomthing;
    }
    interface IAtk
    {
        void Atk();
    }
    interface ISuperAtk
    {
        void Atk();
    }
    #endregion
    #region 接口使用
    class Animal
    {

    }
    class Person:Animal,IFly
    {        
        public void Fly()
        {

        }
        public string Name
        {
            get;
            set;
        }
        public int this[int index]
        {
            get { return 0; }
            set { }
        }
        public event Action doSomthing;
    }
    class Player1 : IAtk, ISuperAtk
    {
        public void Atk()
        {

        }
        //显示实现接口
        void IAtk.Atk()
        {
            throw new NotImplementedException();
        }

        void ISuperAtk.Atk()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region 密封方法
    //用密封关键字sealed 修饰的重写函数
    //作用：让虚方法或抽象方法之后不能再被重写
    //特点：和override一起出现

   

    abstract class Animals
    {
        public string name;
        public abstract void Eat();
        public virtual void Speak()
        {
            Console.WriteLine("叫");
        }
    }
    class SmallP : Animals
    {
        public sealed override void Eat()
        {
            throw new NotImplementedException();
        }
        public override void Speak()
        {
            base.Speak();
        }
    }
    class S_SmallP : SmallP
    {
        
        public override void Speak()
        {
            base.Speak();
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 多态
            Father father = new Son();
            father.SpeakName();
            (father as Son).SpeakName();

            GameObject p = new Player("xiao");
            p.Atk();

            GameObject r = new Monster("sd");
            r.Atk();

            #endregion
            #region 抽象类和抽象方法

            #endregion
            #region 接口
            IFly f = new Person();

            IAtk ia = new Player1();
            ISuperAtk iaa=new Player1();
            ia.Atk();
            iaa.Atk();
            
            Player1 e = new Player1();
            (e as IAtk).Atk();
            (e as ISuperAtk).Atk();
            e.Atk();

            //总结：
            //1.接口值包含 成员方法、属性、索引器、事件、并且都不实现，都没有访问修饰符
            //2.可以继承多个接口，但是只能继承一个类
            //3.接口可以继承接口，相当于在进行行为合并，待子类继承时再去实现具体的行为
            //4.接口可以被显示实现 主要用于实现不同接口中的同名函数的不同表现
            //5.实现的接口方法 可以加virtual关键字 之后子类再进行重写

            #endregion
            Console.ReadKey();

        }
    }
}
