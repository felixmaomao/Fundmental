using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础知识轰炸
{
    class 泛型方法一
    {
        public static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            Swap<int>(ref num1,ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            StringBuilder builder = new StringBuilder("first");
            StringBuilder builder2 = new StringBuilder("second");
            Swap<StringBuilder>(ref builder,ref builder2);
            Console.WriteLine(builder);
            Console.WriteLine(builder2);
            Console.ReadKey();
        }
        public static void Swap<T>(ref T o1,ref T o2)
        {
            T temp = o1;
            o1 = o2;
            o2 = temp;
        }
    }
}
