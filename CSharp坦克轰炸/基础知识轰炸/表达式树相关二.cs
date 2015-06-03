//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Reflection;
//using System.Linq.Expressions;
//namespace 基础知识轰炸
//{
//    class 表达式树相关二
//    {
//        public static void Main(string[] args)
//        {
//            //首先直接调用肯定最简单
//            Console.WriteLine("---直接调用---");
//            Foo foo = new Foo();
//            Console.WriteLine(foo.AddNum(1,2));
//            Console.WriteLine("---反射调用---");
//            MethodInfo method = typeof(Foo).GetMethod("AddNum");
//            int n=Convert.ToInt32(method.Invoke(foo,new object[]{1,2}));
//            Console.WriteLine(n);
//            //现在的情况是 我们知道反射调用性能不好，主要在于执行 invoke的时候，所以我们希望有其他的方式来
//            //我们知道委托也可以实现对方法的调用,就是需要把方法 翻译成对应的委托，那么针对本实例
//            //下面这个就是我们需要的委托
//            Console.WriteLine("---委托调用---");
//            var bar = new Foo();
//            Func<int, int, int> delegateaddnum = (a, b) =>  bar.AddNum(a,b); ;
//            //那么方法的调用就变成了
//            Console.WriteLine(delegateaddnum(1,2));
//            //但是能得到上面符合形式的委托是我们肉眼观察得到的结果。
//            MethodInfo m=typeof(Foo).GetMethod("AddNum");
//            var math = Expression.Parameter(typeof(Foo));
//            ParameterExpression paraa = Expression.Parameter(typeof(int),"a");
//            ParameterExpression parab = Expression.Parameter(typeof(int),"b");
//            var body = Expression.Call(math,m,paraa,parab);
//            var lambda = Expression.Lambda<Func<Foo,int, int, int>>(body,math,paraa,parab);
//            Func<Foo,int, int, int> baz = lambda.Compile();
//            Console.WriteLine(baz(foo,1,2));
//            Console.ReadKey();
//        }
//    }
//    class Foo
//    {
//        public int AddNum(int a,int b)
//        {
//            return a + b;
//        }
//    }
//}
