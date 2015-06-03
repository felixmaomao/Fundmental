//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Linq.Expressions;
//using System.Reflection;
//namespace 基础知识轰炸
//{
//    //回头想想，调用一个方法需要什么？ 
//    //是否static ， 需要的参数列表
//    class 方法调用之表达式树
//    {
//        public static void Main(string[] args)
//        {
//            MethodInfo methodadd = typeof(test).GetMethod("add");
//            MethodInfo methodminus = typeof(test).GetMethod("minus");
//            var para1 = Expression.Parameter(typeof(int),"m");
//            var para2 = Expression.Parameter(typeof(int),"n");
//            var para3 = Expression.Parameter(typeof(int),"k");            
//            var body = Expression.Call(methodadd,para1,para2,para3);
//            var lambda = Expression.Lambda<Func<int,int,int,int>>(body,para1,para2,para3);
//            Func<int, int, int, int> m = lambda.Compile();
//            Console.WriteLine(m(1,1,1));
//            var instance = Expression.Parameter(typeof(test));
//            var body2 = Expression.Call(instance,methodminus,para1,para2);
//            var lambda2 = Expression.Lambda<Func<test, int, int,int>>(body2,instance,para1,para2);
//            Func<test,int,int,int> n=lambda2.Compile();
//            Console.WriteLine(n(new test(),3,1));

//            Console.ReadKey();
//        }
//    }

//    class test
//    {
//        public static int add(int a,int b,int c)
//        {
//            return a + b + c;
//        }
//        public int minus(int a,int b)
//        {
//            return a - b;
//        }
//    }

//}
