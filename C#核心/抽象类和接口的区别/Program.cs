using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类和接口的区别
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 相同点
            //1.都可以被继承
            //2.都不能直接实例化
            //3.都可以包含方法申明
            //4.子类必须实现未被实现的方法
            //5.都遵循里氏替换原则

            #endregion
            #region 区别
            //1.抽象类中可以有构造函数                                     而接口中不能
            //2.抽象类只能被单一继承                                       接口能被继承多个
            //3.抽象类可以有成员变量                                       接口中不能
            //4.抽象类中可以申明成员方法、虚方法、抽象方法，静态方法       接口中只能申明没有实现的抽象方法
            //5.抽象类方法可以使用访问修饰符                               接口中建议不写，默认public
            #endregion
            #region 如何选择
            //表示对象的用抽象类，表示行为拓展的用接口
            //不同对象拥有的共同行为，我们往往可以使用接口来实现
            //例如：
            //动物是一类对象，我们自然会选择抽象类，而飞翔是一个行为，我们自然会选择接口
            #endregion
        }
    }
}
