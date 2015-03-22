//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    class 如何不使用泛型的尖括号
//    {
//        public static void Main(string[] args)
//        {
//            //在一般的情况下，这样子使用确实没有问题
//            DateTimeList timelist = new DateTimeList();
//            timelist.Add(DateTime.Now);
//            timelist.Add(DateTime.MinValue);
//            timelist.Add(DateTime.MaxValue);
//            foreach (DateTime t in timelist)
//            {
//                Console.WriteLine(t.ToShortDateString());
//            }
//            Console.WriteLine("--如果是作为函数参数呢？--");
//            OutPutDateTimeList(timelist);
//            //按照道理来讲，我们本来的目的就是希望能用dateTimelist来代替List<datetime>
//            List<DateTime> anotherlist = new List<DateTime> { DateTime.Now, DateTime.MaxValue, DateTime.MinValue };
//            //下面这样就是不可以的，这就达不到我们想要的目的了。
//            //OutPutDateTimeList(anotherlist);
//            Console.ReadKey();
//        }
//        public static void OutPutDateTimeList(DateTimeList list)
//        {
//            foreach (DateTime t in list)
//            {
//                Console.WriteLine(t.ToShortDateString());
//            }
//        }

//    }

//    class DateTimeList : List<DateTime>
//    { }

//}
