using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量命名规则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 命名规则
            //1.不能重名
            //2.不能以数字开头
            //3.不能使用程序关键字命名
            //4.不能有特殊符号（下划线除外）

            //建议的命名规则：变量名要有含义->用英文（拼音）表示变量


            #endregion
            #region 常用命名规则
            //驼峰命名法-首字母小写，之后单词首字母大写（变量）
            string myName = "小玺";
            //帕斯卡命名法-所有单词首字母都大写（函数、类）
            string MyName = "dskafj";
            #endregion
        }
    }
}
