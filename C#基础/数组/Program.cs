using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 一维数组概念
            //存储一组相同类型数据的集合

            //声明数组
            int[] a;//未开空间

            short[] a2=new short[2];//开了存储空间

            long[] a3=new long[2] {0,1};//开存储空间并存数据

            int[] a4=new int[] {0,1,2};//开存储空间并存数据

            int[] a5 = {0,1,2};
            #endregion
            #region 一维数组使用
            //1.数组长度
            Console.WriteLine(a3.Length);

            //2.获取元素
            Console.WriteLine(a3[1]);

            //3.遍历
            for(int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine(a3[i]);
            }

            //4.增加数据
            //只能定义新的数组 遍历之后得到 不允许直接增加新元素
            #endregion
            #region 二维数组基本概念
            //二维数组 行标 列标
            //1 2 3
            //4 5 6
            //可以用二维数组 int[2,3]表示（两行三列）

            //声明变量
            int[,] arr;

            int[,] arr2=new int[3,3];

            int[,] arr3= new int[3, 3] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };

            int[,]arr4=new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };

            int[,] arr5 = { { 1, 2, 3, } };


            #endregion
            #region 二维数组使用
            //获取行
            Console.WriteLine(arr4.GetLength(0));

            //获取列
            Console.WriteLine(arr4.GetLength(1));

            //获取二维数组元素
            Console.WriteLine(arr4[0,1]);

            //修改元素
            arr4[0, 1] = 3;

            //遍历数组
            for(int i = 0;i < arr4.GetLength(0);i++)
            {
                for(int j = 0;j < arr4.GetLength(1);j++)
               {
                    Console.WriteLine(arr4[i,j]);
                }
            }

            //增加数组元素 删除数组元素
            //先搬家 后增添或修改

            int[,] b = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] c = new int[3, 3];
            for(int i = 0;i<b.GetLength(0);i++)
            {
                for(int j = 0; j<b.GetLength(1);j++)
                {
                    c[i,j]= b[i,j];
                }
            }
            for(int i = 0; i<c.GetLength(0);i++)
            {
                for(int j=0;j<c.GetLength(1); j++)
                {
                    Console.WriteLine(c[i,j]);
                }
            }
            c = b;

            #endregion
            #region 交错数组
            //交错数组是 数组的数组 每个维度的数量可以不同
            //注意：二维数组每行的列数相同，交错数组每行的列数可能不同

            //数组申明
            //变量类型[][]数组名
            int[][] aa1;

            int[][] aa2 = new int[2][];

            int[][] aa3 = new int[2][] { new int[] { 1, 2 ,3},
                                         new int[]  {1,2 } };

            int[][] aa4 = new int[][]{ new int[] { 1, 2 ,3},
                                         new int[]  {1,2 } };

            int[][] aa5 = { new int[] { 1, 2 ,3},
                           new int[]  {1,2 } };
            #endregion
            #region 交错数组使用
            //数组长度
            //行
            Console.WriteLine(arr3.GetLength(0));

            //列
            Console.WriteLine(aa4.Length);

            //获取元素
            Console.WriteLine(aa4[0][1]);

            //遍历数组
            for(int i = 0; i<aa4.GetLength(0);i++)
            {
                for(int j=0; j<aa4[i].Length;j++)
                {
                    Console.WriteLine(aa4[i][j]);
                }
            }



            #endregion
            Console.ReadKey ();
        }
    }
}
