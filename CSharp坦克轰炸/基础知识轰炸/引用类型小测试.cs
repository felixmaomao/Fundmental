//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    class 引用类型小测试
//    {
//        public static void Main(string[] args)
//        {
//            StringBuilder builder = new StringBuilder();
//            builder.Append("Hello");
//            foo(builder);
//            Console.WriteLine(builder);
//            bar(builder);
//            Console.WriteLine(builder==null);
//            Console.WriteLine(builder);
//            Console.ReadKey();
//        }
//        public static void foo( StringBuilder builder)
//        {
//            //引用类型只是个指向的关系，如果指向同一个东西，对其进行操作，那值必然改变
//            builder.Append("==========");
//            //如果是 = 那只是指向另一个值，并不会影响原乡的。
//            builder = new StringBuilder("xxxxxxxxxxxx");
//        }
//        public static void bar(StringBuilder builder)
//        {
//            //不会影响原先的
//            builder = null;
//        }
//        //如果要想保证对其操作 那就要用 ref 或out 他们相当于找到传入参数的具体地址，然后对其进行操作。
//        //相当于操作的就是原乡的对象，所以一定会发生改变。
//    }
//}
