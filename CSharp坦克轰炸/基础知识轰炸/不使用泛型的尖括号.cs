//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
////命名空间要写完整。
//using DateTimeList = System.Collections.Generic.List<System.DateTime>;
//namespace 基础知识轰炸
//{
//    class 不使用泛型的尖括号
//    {
//        public static void Main(string[] args)
//        {
//            DateTimeList list = new DateTimeList();
//            list.Add(DateTime.Now);
//            list.Add(DateTime.MinValue);
//            list.Add(DateTime.MaxValue);
//            OutPutList(list);
//            Console.WriteLine("===another===");
//            OutPutList(new List<DateTime> { DateTime.Now,DateTime.MaxValue,DateTime.MinValue});
//            Console.ReadKey();
//        }
//        public static void OutPutList(DateTimeList list)
//        {
//            foreach(DateTime t in list)
//            {
//                Console.WriteLine(t.ToShortDateString());
//            }
//        }
//    }

//}
