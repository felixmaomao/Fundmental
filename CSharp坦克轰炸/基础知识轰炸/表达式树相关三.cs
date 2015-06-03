//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Reflection;
//using System.Linq.Expressions;
//namespace 基础知识轰炸
//{
//    class 表达式树相关三
//    {
//        public static void Main(string[] args)
//        {
//            MethodInfo method = typeof(Demo).GetMethod("sayHi");
//            var paraa = Expression.Parameter(typeof(string),"a");
//            var parab = Expression.Parameter(typeof(string),"b");
//            var instance = Expression.Parameter(typeof(Demo));

//            var body = Expression.Call(instance,method,paraa,parab);
//            var lambda = Expression.Lambda<Func<Demo,string,string,string>>(body,instance,paraa,parab);
//            Func<Demo, string, string, string> com = lambda.Compile();
//            Console.WriteLine(com(new Demo(),"shenwei","zhangxiaomao"));
//            Console.ReadKey();

//        }
//    }
//    class Demo
//    {
//        public string sayHi(string a,string b)
//        {
//            return a + b;
//        }
//    }
//}
