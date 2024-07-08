using System;
using System.Collections.Generic;

// 观察者接口
public interface IObserver
{
    void Update(object sender, EventArgs args);
}

// 被观察者抽象类
public abstract class Observable
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    protected void NotifyObservers(object sender, EventArgs args)
    {
        foreach (var observer in observers)
        {
            observer.Update(sender, args);
        }
    }
}

// 怪物类（被观察者）
public class Monster : Observable
{
    public void Die()
    {
        Console.WriteLine("怪物死亡！");
        NotifyObservers(this, EventArgs.Empty);
    }
}

// 玩家类（观察者）
public class Player : IObserver
{
    private int gold = 0;

    public void Update(object sender, EventArgs args)
    {
        Console.WriteLine("玩家获得了10个金币！");
        gold += 10;
    }

    public int GetGold()
    {
        return gold;
    }
}

// 界面类（观察者）
public class Panel : IObserver
{
    public void Update(object sender, EventArgs args)
    {
        Console.WriteLine("界面更新：显示金币信息。");
    }
}

// 成就榜类（观察者）
public class Honour : IObserver
{
    private int killCount = 0;

    public void Update(object sender, EventArgs args)
    {
        Console.WriteLine("成就榜更新：显示击杀数量。");
        killCount++;
        Console.WriteLine($"总击杀数：{killCount}");
    }
}

// 游戏主程序
class Program
{
    static void Main()
    {
        // 创建怪物、玩家、界面和成就榜
        Monster monster = new Monster();
        Player player = new Player();
        Panel panel = new Panel();
        Honour honour = new Honour();

        // 玩家、界面和成就榜订阅怪物的死亡事件
        monster.AddObserver(player);
        monster.AddObserver(panel);
        monster.AddObserver(honour);

        Console.WriteLine("欢迎来到游戏！输入 'A' 进行攻击，其他键结束游戏。");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToUpper() == "A")
            {
                // 模拟怪物受到攻击
                Console.WriteLine("怪物受到攻击！");

                // 判断怪物是否死亡
                if (new Random().Next(0, 2) == 0)
                {
                    // 怪物死亡
                    monster.Die();
                    Console.WriteLine($"玩家的金币数量：{player.GetGold()}");
                }
                else
                {
                    Console.WriteLine("怪物未死亡，继续攻击！");
                }
            }
            else
            {
                // 退出游戏
                break;
            }
        }

        Console.WriteLine("游戏结束。");
    }
}
