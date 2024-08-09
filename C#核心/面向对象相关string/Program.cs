using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象相关string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 字符串指定位置获取

            //字符串本质是char数组
            string str = "xiao";
            Console.WriteLine(str[0]);
            //转为char数组
            char[] chars=str.ToCharArray();
            Console.WriteLine(chars[1]);

            for(int i = 0;i<str.Length;i++)
            {
                Console.Write(str[i]);
            }


            #endregion
            #region 字符串拼接
            str = string.Format("{0}{1}", 1, 333);
            Console.WriteLine(str);
            #endregion
            #region 正向查找字符位置
            str = "xiaoxi";
            int index=str.IndexOf("i");
            Console.WriteLine(index);

            index = str.IndexOf("a");
            Console.WriteLine(index);
            #endregion
            #region 反向查找指定字符串位置
            str = "xiaoxii";
            index = str.LastIndexOf("xi");
            Console.WriteLine(index);//从前面开始数位置

            index=str.LastIndexOf("a");
            Console.WriteLine(index);
            #endregion
            #region 移除指定位置后的字符
            str = "xiaoxi";
            str.Remove(1);
            Console.WriteLine(str);//打印出来还是xiaoxi
            str=str.Remove(1);
            Console.WriteLine(str);//打印出来是x

            //执行两个参数进行参数
            //参数1 开始位置
            //参数2 字符个数
            str = str.Remove(1, 1);
            Console.WriteLine(str);


            #endregion
            #region 替换指定字符串
            str = "xiaoxi";
            str.Replace("xiao", "wo");
            Console.WriteLine(str);
            str=str.Replace("xiao", "wo");
            Console.WriteLine(str);
            #endregion
            #region 大小写转换
            str = "dfsf";
            str.ToUpper();
            Console.WriteLine(str);
            str=str.ToUpper();
            Console.WriteLine(str);

            str=str.ToLower();
            Console.WriteLine(str);
            #endregion
            #region 字符串截取
            str = "xiaoxi";
            str=str.Substring( 1);
            Console.WriteLine(str);//打印出来是iaoxi

            str = "xiaoxi";
            //参数一 开始位置
            //参数二 指定个数
            str = str.Substring(0, 1);
            Console.WriteLine(str);
            #endregion
            #region 字符串切割
            str = "1,2,3,4,5,6,7,8";
            string[] strs = str.Split(',');
            for(int i = 0;i<strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
            #endregion
            #region StringBuilder
            //c#提供的一个用于处理字符串的公共类
            //解决的问题是：
            //修改字符串而不创建新的对象，需要频繁修改和拼接的字符串可以使用它，可以提升性能
            //使用前 需要引用命名空间

            StringBuilder strr=new StringBuilder("123123");
            Console.WriteLine(strr);

            //容量
            //StringBuilder存在一个容量的问题，每次往里面增加时，会自动扩容
            //获得容量
            Console.WriteLine(strr.Capacity);

            //获得字符长度
            Console.WriteLine(strr.Length);

            //增加容量
            strr.Append("444");
            strr.AppendFormat("{0}{1}", 100, 999);

            //插入容量
            strr.Insert(0, "asd");

            //删除
            //参数1 位置
            //参数2 个数
            strr.Remove(0, 1);
            //清空
            strr.Clear();

            //查找
            Console.WriteLine(strr[0]);

            //改
            strr[0] = 'd';
            Console.WriteLine(strr);

            //替换
            strr.Replace("2","d");
            Console.WriteLine(strr);

            //重写赋值 StringBuilder
            strr.Clear();
            strr.Append("123456");
            Console.WriteLine(strr);

            //判断
            if(strr.Equals("123123"))
            {
                Console.WriteLine("相等");
            }
            #endregion
            Console.ReadKey();

        }
    }
}
