//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Diagnostics;
//using System.Reflection;
//namespace 基础知识轰炸
//{

//    //此例可以明显的看出 直接调用和反射调用性能上的差距
//    class 反射相关二
//    {
//        public static void Main(string[] args)
//        {
//            int times = 1000000;
//            Console.WriteLine("---直接调用----");
//            Stopwatch watch1 = new Stopwatch();
//            watch1.Start();
//            for (int i = 0; i < times;i++ )
//            {
//                Person.SayHi();
//            }           
//            watch1.Stop();
//            Console.WriteLine(watch1.ElapsedMilliseconds);
//            Console.WriteLine("---反射调用---");
//            Stopwatch watch2 = new Stopwatch();
//            watch2.Start();
//            for (int i = 0; i < times;i++ )
//            {
//                Type type = typeof(Person);
//                MethodInfo method = type.GetMethod("SayHi");
//                method.Invoke(null, null);
//            }
            
//            watch2.Stop();
//            Console.WriteLine(watch2.ElapsedMilliseconds);
//            Console.ReadKey();
//        }
//    }

//    public class Person
//    {
//        public static void SayHi()
//        {
            
//        }
//    }
//}
