using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public const int width = 100;
        public const int height =20;
        static void Main(string[] args)
        {
            Console.SetWindowSize(width, height);
        
            Console.SetBufferSize(width, height);

            Console.ReadKey();
        }
    }
}
