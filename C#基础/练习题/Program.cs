using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 练习题
{
    #region 练习1
    /// <summary>
    /// 在线
    /// </summary>
    enum E_age
    {
        man,
        women
    }
    enum E_zhiye
    {
        Zanshi,
        Lieren,
        Fashi
    }
    #endregion
    #region 3
    struct Monster
    {
        public int Id;
        public string name;
        public string fight;
        public Monster(int id, string name,string fight)
        {
            this.Id = id;
            this.name = name;
            this.fight = fight;
            Console.WriteLine("小怪兽" + id + "名字：" + name + "攻击力：" + fight);


        }
    }
    #endregion
    


    internal class Program
    {
        #region 2
        static bool User_Z(string temp, string password, ref string info)
        {
            if (temp == "123")
            {
                if (password == "456")
                {
                    info = "登录成功";
                }
                else
                {
                    info = "密码错误";
                    return false;
                }

            }
            else
            {
                info = "用户名错误";
                return false;
            }

            return true;

        }
        #endregion

        static void Main(string[] args)
        {

            #region 练习1
            Console.WriteLine("请选择英雄性别");
            int t1 = int.Parse(Console.ReadLine());
            Enum e_age = (E_age)(t1);
            if (t1 >= 0)
            {
                switch (e_age)
                {
                    case E_age.man:
                        Console.WriteLine("请选择英雄职业");
                        int t_2 = int.Parse(Console.ReadLine());
                        Enum e_age2 = (E_zhiye)(t_2);
                        switch (e_age2)
                        {
                            case E_zhiye.Zanshi:
                                Console.WriteLine("选了战士");
                                break;
                            case E_zhiye.Lieren:
                                Console.WriteLine("选了猎人");
                                break;
                            case E_zhiye.Fashi:
                                Console.WriteLine("选了法师");
                                break;
                        }
                        break;
                    case E_age.women:
                        Console.WriteLine("选择了女性");
                        break;
                }

            }
            #endregion
            #region 2
            string temp=Console.ReadLine();
            string password=Console.ReadLine();
            string info = "";
            User_Z(temp,password,ref info);
            Console.WriteLine(info);
            #endregion

            #region 3
          
            Monster[] monster = new Monster[10];
            for (int i = 0; i < monster.Length; i++)
            {
    //            monster[i] = new Monster( i+"mingzi"+"dfsf");
             
               
            }
            #endregion
            #region 4
            Random random = new Random();

            int[]a6=new int[20];

            for(int i = 0;i < a6.Length;i++)
            {
                a6[i] = random.Next(0, 20);
            }

            for(int i = 0;i<a6.Length;i++)
            {
                int index = 0;
                for (int j = 0;j<a6.Length-1-i;j++)
                {
                   
                    if (a6[index]<a6[j])
                    {
                        index = j;
                    }
                }

                if(index!=a6.Length-1-i)
                {
                    int temp1 = a6[index];
                    a6[index] = a6[a6.Length-1-i];
                    a6[a6.Length-1-i] = temp1;

                }
            }
            for(int i = 0;i<a6.Length;i++)
            {
                Console.WriteLine(a6[i]);
            }
            #endregion
            Console.ReadKey();
 
           

        }
    }
}
