using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List排序
{
    class Item:IComparable<Item>
    {
        public int money;

        public Item(int money)
        {
            this.money = money;
        }

        public int CompareTo(Item other)
        {
            //返回值的含义
            //小于0：放在传入对象的前面
            //等于0：保持当前位置不变
            //大于0：放在传入对象的后面

            //可以简单理解 传入对象的位置 就是0
            //如果你的返回为负数 就放在它的左边 
            //如果你返回正数     就放在它的右边

            if(this.money<other.money)
            {
                return 1;
            }
            else
            {
                 return -1;
            }
            return 0;
        }
    }
    class ShopItem
    {
        public int id;

        public ShopItem(int id)
        {
            this.id= id;    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List自带排序方法
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);     
            list.Add(5);

            //list提供了排序方法(升序）
            list.Sort();
            for(int i = 0;i < list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }

            //ArrayList中也有Sory方法

            //总结
            //系统自带的变量（int，float，double。。。）一般都可以直接Sort
            //自定义类Sort有两种方式
            //1.继承接口 IComparable
            //2.在Sort中传入委托函数
            #endregion
            #region 自定义类排序
            List<Item> list2 = new List<Item>();
            list2.Add(new Item(3));
            list2.Add(new Item(2));
            list2.Add(new Item(29));
            //排序
            list2.Sort();
            for(int i = 0;i<list2.Count;i++)
            {
                Console.WriteLine(list2[i].money);
            }
            #endregion
            #region 通过委托来进行排序
            List<ShopItem> shop=new List<ShopItem>();
            shop.Add(new ShopItem(5));
            shop.Add(new ShopItem(6));
            shop.Add(new ShopItem(9));
            shop.Add(new ShopItem(10));

            shop.Sort(SortShopItem);

            shop.Sort(delegate (ShopItem a, ShopItem b)
            {
                if (a.id < b.id)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });

            shop.Sort((a, b) =>
            {
                return a.id < b.id ? 1 : -1;
            });

            for(int i = 0; i<shop.Count;i++)
            {
                Console.WriteLine(shop[i].id);
            }
            #endregion
        }
        static int SortShopItem(ShopItem a, ShopItem b)
        {

            //传入的两个对象 为列表中的两个对象
            //进行两两比较 用左边的和右边的条件 比较
            //返回值规则 和之前一样 

            if (a.id < b.id)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            return 0;
        }         
            
        
    }
}

