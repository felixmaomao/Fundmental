//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Reflection;
//using System.Diagnostics;
//using System.Linq.Expressions;
//namespace 基础知识轰炸
//{
//    class 反射相关三
//    {
//        public static void Main(string[] args)
//        {
//            int times = 1000000;
//            Program program = new Program();
//            object[] objs = new object[] { new object(), new object(), new Object() };
//            Stopwatch watch1 = new Stopwatch();
//            watch1.Start();
//            for (int i = 0; i < times; i++)
//            {
//                program.sayHi(objs[0], objs[1], objs[2]);
//            }
//            watch1.Stop();
//            Console.WriteLine(watch1.Elapsed);
//            Console.WriteLine("-------------------");
//            Stopwatch watch2 = new Stopwatch();
//            watch2.Start();
//            for (int i = 0; i < times; i++)
//            {
//                MethodInfo method = typeof(Program).GetMethod("sayHi");
//                method.Invoke(program, objs);
//            }
//            watch2.Stop();
            
//            Console.WriteLine(watch2.Elapsed);
//            Console.ReadKey();
//        }
//    }

//    class Program
//    {
//        public void sayHi(object o1, object o2, object o3) { }
//    }
//}
