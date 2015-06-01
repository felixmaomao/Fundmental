//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Linq.Expressions;
//namespace 基础知识轰炸
//{
//    class 表达式树相关
//    {
//        public static void Main(string[] args)
//        {
//            //这是在已经有了lambda表达式的基础上包装成 expression 然后 可以在编译成delegate
//            Expression<Func<int, int>> mutiply = x => x * 10;
//            Func<int, int> demo = mutiply.Compile();
//            Console.WriteLine(demo(5));

//            //直接拼接 expression
//            ParameterExpression parameter1 = Expression.Parameter(typeof(int),"x");
//            ConstantExpression constant=Expression.Constant(10);
//            BinaryExpression muti = Expression.Multiply(parameter1,constant);
//            Expression<Func<int, int>> haha = Expression.Lambda<Func<int, int>>(muti,parameter1);
//            Func<int, int> foo = haha.Compile();
//            Console.WriteLine(foo(6));

           
//            Console.ReadKey();
//        }
//    }
//}
