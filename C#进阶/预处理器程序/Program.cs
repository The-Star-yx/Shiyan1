
#define UNity
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 预处理器程序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 编译器
            //是一种翻译程序
            //它用于将源语言程序翻译为目标语言程序

            //源语言程序：某种程序设计语言写成的
            //目标语言程序：二进制数表示的伪机器代码写的程序
            #endregion
            #region 预处理器指令
            //预处理器指令 指导编译器 在实际编译开始之前对信息进行预处理
            //预处理指令 都是以#开始
            //预处理器指令不是语句，所以它们不以分号;结束
            //目前我们经常用到的 折叠代码块 就是预处理器指令
            #endregion
            #region 使用
            //1.
            //#define
            //定义一个符号，类似一个没有值的变量
            //#undef
            //取消define定义的符号，让其失效
            //两者都是写在脚本文件的最前面
            //一般配合 if指令使用 或配合特性

            //2.
            //#if
            //#else
            //#endif
            //和if语句规则一样，一般配合#define定义的符号使用
            //用于高速编译器进行编译代码的流程控制
            //例如： 有UNity符号 则会打印其中内容
#if UNity
            Console.WriteLine("打印");
#endif
            
            //3.
            //#warning
            //#error
            //告诉编译器 是报告警告还是报错误
            //一般还是配合if使用

#endregion
        }
    }
}
