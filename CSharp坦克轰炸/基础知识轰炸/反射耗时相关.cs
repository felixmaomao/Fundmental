//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Reflection;
//using System.Diagnostics;
//namespace 基础知识轰炸
//{
//    class 反射耗时相关
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Normal");
//            Stopwatch watch1 = new Stopwatch();
//            watch1.Start();
//            for (int i = 0; i < 1000000;i++ )
//            {
//                NormalInvoke();
//            }         
//            watch1.Stop();
//            Console.WriteLine(watch1.Elapsed);
//            Console.WriteLine("-------------");
//            Console.WriteLine("reflection");
//            Stopwatch watch2 = new Stopwatch();
//            watch2.Start();
//            for (int i = 0; i < 1000000;i++ )
//            {
//                ReflectionInvoke();
//            }           
//            watch2.Stop();
//            Console.WriteLine(watch2.Elapsed);
//            Console.WriteLine("-------------");
//            Console.WriteLine("interfacereflection");
//            Stopwatch watch3 = new Stopwatch();
//            watch3.Start();
//            for (int i = 0; i < 1000000; i++)
//            {
//                ReflectionWithInterface();
//            }
//            watch3.Stop();
//            Console.WriteLine(watch3.Elapsed);
//            Console.ReadKey();
//        }
//        public static void NormalInvoke()
//        {
//            Person p = new Person();
//            p.sleep("shenwei");
//        }
//        public static void ReflectionInvoke()
//        {
//            Type type=typeof(Person);
//            var instance = Activator.CreateInstance(type);
//            MethodInfo method = type.GetMethod("sleep");
//            method.Invoke(instance,new object[]{"zhangxiaomao"});
//        }
//        public static void ReflectionWithInterface()
//        {
//            Type type = typeof(Person);
//            var instance = Activator.CreateInstance(type);
//            IPerson p = instance as IPerson;
//            MethodInfo method = type.GetMethod("sleep");
//            method.Invoke(p, new object[] { "zhangxiaomao" });
//        }

//    }

//    public interface IPerson
//    {
//        void sleep(string name);
//    }
//    public class Person : IPerson
//    {
//        public void sleep(string name)
//        {
            
//        }
//    }
//}
