using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 特殊语法
{
    class Person
    {
        private int money;
        public bool sex;
        public int age;

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Name
        {
            get => "xiaoxi";  //一句代码省略写法 =>
            set => sex = true;
        }
        public int Age
        {
            get => 123;
            set { value=age; }
        }

        public Person(int money)
        {
            this.money = money;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region var隐式类型
            //var是一种特殊的变量类型
            //它可以用来表示任意类型的变量
            //注意：
            //1.var不能作为类的成员 只能用于临时变量申明时
            // 也就是 一般写在函数语句块中
            //2.var必须初始化

            var i = 0;
            var s = "123";
            var array = new int[] { 1, 2 };
            var list=new List<int>();


            #endregion
            #region 设置对象初始值
            //申明对象时
            //可以通过直接写大括号的形式初始化公共成员变量和属性

            Person p=new Person(100) {sex=true,Age=10,Name="xiaoxi" };
            Person p1 = new Person(200){ Age = 16 };
            #endregion
            #region 设置集合初始值
            //申明集合对象时
            //也可以通过大括号 直接初始化内部属性

            int[] arr= new int[] { 1,2 };

            List<int> list2= new List<int>() { 1, 2, 3 };

            List<Person> list3 = new List<Person>() { 
                new Person(100),
                new Person(200){Age=10,sex=true,Name="sdf"}
            };

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1,"123" },
                {2,"df" },
            };


            #endregion
            #region 匿名类型
            //var 变量可以申明为自定义的匿名类型
            var v = new { age = 10, money = 11, name = "xffsf" };
            Console.WriteLine(v.age);
            Console.WriteLine(v.money);
            #endregion
            #region 可空类型
            //1.值类型是不能赋值为 空

            //2.申明时 在值类型前面加 ？ 可以赋值为空
            int? c = null;

            //3.判断是否为空
            if(c.HasValue)
            {
                Console.WriteLine(c);
                Console.WriteLine(c.Value);
            }

            //4.安全获取可空类型
            int? value = null;
            //4-1 如果为空 默认返回值类型的默认值
            Console.WriteLine(value.GetValueOrDefault());
            //4-2 也可以指定一个默认值
            Console.WriteLine(value.GetValueOrDefault(100) );

            object o=null;
            if(o!=null)
            {
               Console.WriteLine( o.ToString());
            }

            //例：相当于一种语法糖 能够帮助我们自动去判断o是否为空
            //如果是null就不会执行tostring也不会报错
            Console.WriteLine(o?.ToString());

            int[] arrayInt = null;
            Console.WriteLine(arrayInt?[0]);

            Action action = null;
            if(action!= null) 
            {
                action();
            }

            action?.Invoke();
            #endregion
            #region 空合并操作符
            //空合并操作符 ？？
            //左边值 ？？ 右边值
            //如果左边值为null 就返回右边值 否则返回左边值
            //只要是可以为null的类型都能用

            int?intV = null;

            int intI=intV==null ? 100 : intV.Value;

            int intI1 = intV ?? 100;

            string str = null;
            str = str ?? "haha";
            Console.WriteLine(str); //打印haha
            #endregion
            #region 内插字符串
            //关键符号：$$$
            //用$来构造字符串，让字符串可以拼接变量
            string name = "123";
            Console.WriteLine($"sdff,{name}");//打印sdff123

            int age = 12;
            Console.WriteLine($"xiaoxi,{age}");



            #endregion
            #region 单句逻辑简略写法
            //当循环或者if语句只有一句代码时 大括号可以省略
            if (true)
                Console.WriteLine("123");

            for (int j = 0; j < 10; j++)
                Console.WriteLine(j);

            while(true)
                Console.WriteLine();
            #endregion
        }
    }
}
