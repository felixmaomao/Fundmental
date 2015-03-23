//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
////除了这些继承关系的约束 有没有其他类型的约束？
//    class 泛型约束二次约束
//    {
//        public static void Main(string[] args)
//        {
//            IList<string> strings = new List<string> {"shenwei","zhangxiaomao","shenjiaju"};
//            List<object> objs=ConvertToList<string,object>(strings);
//           //从一个多元素集合转化到另一个多元素集合，使用的是简单的循环搬运。
//            foreach(object o in objs)
//            {
//                Console.WriteLine(o.ToString());
//            }
//            Console.ReadKey();
//        }

//        //这个纷繁复杂的方法很巧妙，他将Ilist<T>的参数转化成List<TBase> 很显然要想转化成功，类型之间必有约束
//        public static List<TBase> ConvertToList<T,TBase>(IList<T> para) where T:TBase
//        {
//            int count = para.Count();
//            List<TBase> list = new List<TBase>(count);
//            foreach(T t in para)
//            {
//                list.Add(t);
//            }
//            return list;
//        }

//    }


//}
