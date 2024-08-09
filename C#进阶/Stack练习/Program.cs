using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack练习
{
    
    
    internal class Program
    {
        static void Calc(uint num)
        {
            Stack stack = new Stack();
            while(true)
            {
                stack.Push(num % 2);
                num /= 2;
                if(num==1)
                {
                    stack.Push(num);
                    break;
                }
            }
            while(stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            Calc(2);
            Console.ReadKey();
           
        }
    }
}
