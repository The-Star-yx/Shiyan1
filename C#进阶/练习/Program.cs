using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList练习
{
    class Bag
    {
        private ArrayList items;
        private int money;
        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public Bag(int money) 
        {
            this.money = money;
            items=new ArrayList();
        }
        public void Buy(Item item)
        {
            if(item.num<=0||item.money<0)
            {
                Console.WriteLine("请输入正确的物品信息");
                return;
            }

            if(this.money<item.money*item.num)
            {
                Console.WriteLine("钱不够");
                return;
            }

            this.money -= item.money * item.num;
            Console.WriteLine("购买{0}{1}个花费{2}", item.name, item.num, item.money * item.num);


            //如果想要叠加物品 可以在前面先判断 是否有这个物品 然后加数量

            for(int i=0; i<items.Count; i++)
            {
                if ((items[i] as Item).id==item.id)
                 {
                    //叠加数量
                    (items[i] as Item).num += item.num;

                    return;
                 }
            }
            items.Add(item);
        }
        public void Sell(Item item)
        {
            for(int i = 0; i<items.Count;i++)
            {
                if ((items[i] as Item).id==item.id)
                {
                    //两种情况
                    string name = (items[i] as Item).name;
                    int money = (items[i] as Item).money;                                          

                    int num = 0;
                    if ((items[i] as Item).num>item.num)
                    {
                        //1.比我身上的少
                        num = item.num;
                    }
                    else
                    {
                        //2.大于等于我身上的东西数量
                        num = (items[i] as Item).num;
                        //卖完了 就从身上移除
                        items.RemoveAt(i);
                    }
                    int sellMoney = (int)(num*money * 0.8f);
                    this.money += sellMoney;

                    Console.WriteLine("卖了{0}{1}个，赚了{2}钱", name,num,sellMoney);
                    Console.WriteLine("现在拥有{0}钱",this.money);

                    return;
                }
            }
        }
        public void Sell(int id,int num=1)
        {
            //直接调用上面写好的方法
            //直接构造一个Item类 把ID和数量两个关键信息设置了即可 就可以卖了

            Item item = new Item(id,num);
            item.id= id;
            item.num = num;
            Sell(item);

        }
        public void Sell(string name)
        {

        }
        public void Show()
        {
            Item item;
            for(int i = 0;i<items.Count;i++)
            {
                item = items[i] as Item;
                Console.WriteLine("有{0}{1}个",item.name,item.money);
            }
            Console.WriteLine("当前拥有{0}钱", this.money);
        }
    }
    class Item
    {
        public int id;  
        public int money;
        public string name;
        public int num;
        public Item(int id,int num)
        {
            this.id = id;
            this.money = num;
        }

        public Item(int id, int money, string name, int num)
        {
            this.id = id;
            this.money = money;
            this.name = name;
            this.num = num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag(100000000);
            Item item1 = new Item(1, 10, "红药", 10);
            Item item2 = new Item(1, 100, "红药", 10);
            Item item3 = new Item(1, 1000, "红药", 5);
            Item item4 = new Item(1, 10000, "红药", 1);

            bag.Buy(item1);
            bag.Buy(item2);
            bag.Buy(item3);
            bag.Buy(item4);

            bag.Sell(item1);

            Console.ReadKey();
        }
    }
}
