//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Linq.Expressions;
//namespace 基础知识轰炸
//{
//     class ExpressionTree
//    {
//         public static void Main(string[] args)
//         {
//             Expression<Func<string, string>> foo = a => a + 10;
//             Func<string, string> bar = foo.Compile();
//             Console.WriteLine(bar("shenwei"));
//             Console.WriteLine("-----------");

//             ParameterExpression para1 = Expression.Parameter(typeof(int),"a");
//             ConstantExpression const1 = Expression.Constant(10);
//             BinaryExpression expr = Expression.Add(para1,const1);
//             Expression<Func<int, int>> baz = Expression.Lambda<Func<int, int>>(expr,para1);
//             Func<int, int> demo = baz.Compile();
//             Console.WriteLine(demo(10));
//             Console.ReadKey();
//         }
//    }
//}
