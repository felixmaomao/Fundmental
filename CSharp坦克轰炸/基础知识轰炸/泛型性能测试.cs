//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Diagnostics;
//using System.Collections;
//namespace 基础知识轰炸
//{
//    class 泛型性能测试
//    {
//        //对于值类型的话因为涉及装箱拆箱所以运行时间差 几乎在10倍数量级
//        //对于引用类型的话，这一差距要小一点，但是都能看出来是 泛型的性能要好的多。
//        //通过这个性能测试还可以感受到的一点是：单线程必须等前面的代码执行完才能执行后面的代码。
//        public static void Main(string[] args)
//        {
//            ValueTypePerf();
//        }

//        public static void ValueTypePerf()
//        {
//            const int count = 10000000;
//            ArrayList arr = new ArrayList();
//            Console.WriteLine("--normal--");
//            Stopwatch watch = new Stopwatch();
//            watch.Start();
//            for (int i = 0; i < count;i++ )
//            {
//                arr.Add(i);
//                int x=(Int32)arr[i];
//            }
//            watch.Stop();
//            arr = null;
//            Console.WriteLine("Normal:"+watch.ElapsedMilliseconds);
//            Console.WriteLine("--generic--");
//            List<Int32> genearr = new List<int>();
//            watch.Restart();
//            for (int i = 0; i < count;i++ )
//            {
//                genearr.Add(i);
//                int y=genearr[i];
//            }
//            watch.Stop();
//            genearr = null;
//            Console.WriteLine("Generic:"+watch.ElapsedMilliseconds);
//            Console.ReadKey();

//        }

//    }
//}
