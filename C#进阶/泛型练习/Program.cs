using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 泛型练习
{
    internal class Program
    {
        static string Te<T>(T value)
        {
            if(typeof(T)==typeof(int))
            {
                return string.Format("{0},{1}字节", "整形", sizeof(int));
            }
            return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Te<int>(123));
            Console.ReadKey();
            
        }
    }
   
}
