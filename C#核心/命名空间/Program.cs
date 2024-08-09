using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 命名空间.MyGame;

namespace 命名空间
{
    #region 概念
    //命名空间是用来组织和重用代码的
    //作用
    //就像是一个工具包，类像是一件一件的工具

    //using 空间名

    //不同命名空间中允许有同名类
    //不同命名空间中相互使用 需要引用命名空间或指明出处

    //命名空间可以包裹命名空间

    //关于修饰类的访问修饰符
    //public 命名空间中的类 默认为internal
    //internal 只能在该程序集中使用
    //abstract 抽象类
    //sealed   密封类
    //partial  分部类


    namespace MyGame
    {
        class GameObject
        {

        }
    }
    namespace MyGame
    {
        class Player:GameObject 
        {

        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject game = new GameObject();
            MyGame.GameObject s=new MyGame.GameObject();
        }
    }
}
