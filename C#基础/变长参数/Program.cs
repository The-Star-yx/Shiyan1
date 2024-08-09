using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变长参数
{
    internal class Program
    {
        //变长参数关键字 params
        static int Sum(params int[] arr) 
        { 
            int sum = 0;    
            for(int i = 0; i < arr.Length; i++)
            {
                sum+= arr[i];   
            }
            return sum;
        }

        //作用：可以传入n个同类型参数 n可以为0
        //params int[] 意味着可以传入n个int参数 n可以等于0 传入的参数会存在arr数组中
        //注意：
        //1.params关键字后面必须为数组
        //2.数组的类型可以是任意的类型

        //3.函数参数可以有 别的参数和params关键字修饰的参数
        //4.函数参数中只能最多出现一个params关键字 并且一定是在最后一组参数 前面可以有n个其他参数

        //参数默认值（可选参数）
        //作用：
        //当调用函数时可以不传入参数，不传就会使用默认值作为参数的值
        //注意：
        //1.可选参数可以有多个
        //2.正常参数写在可选参数前面，可选参数只能写在所有参数的后面
        static void Speak(string str="shif")
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {

            Speak("123");
        }
    }
}
