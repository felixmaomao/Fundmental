//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;


////http://www.codeproject.com/Articles/195369/Simple-Method-Caching
//namespace 基础知识轰炸
//{
//    class 让方法自我缓存
//    {
//        public static void Main(string[] args)
//        {
//            TestClass c = new TestClass();
//            //Console.WriteLine(c.doadd(1));

//            Func<int, int> m = CacheProvider.Decorate<int, int>(c.add);
//            Console.WriteLine(m(2));
//            Console.ReadKey();
//        }
//    }
//    public class SampleClass
//    {
//        //对于确定的输入，这个方法会得出唯一的结果。这是我们的大前提
//        public int Caculate(int input)
//        {
//            //我们假设在这里会进行特别繁琐的步骤,那么我们就有必要对于这个方法进行缓存。
//            Dictionary<int, int> _cache = new Dictionary<int, int>();
//            if (!_cache.ContainsKey(input))
//            {
//                int result = input * 2;
//                _cache.Add(input, result);
//            }
//            return _cache[input];
//        }
//    }
//    //诚然，上面的做法 符合我们的需求。下次我们如果有其他方法 也需要类似的“缓存”功能，我们可以仿照上面的逻辑即可。
//    //但是，程序员要精益求精的“偷懒”。我们能不能写个方法，专门用来赋予我们需要的方法记忆功能呢？

//    public static class CacheProvider
//    {
//        //装饰~~  对于只针对单参数 单返回值的方法，赋予其记忆  (很精妙的写法，  学会举一反三)
//        public static Func<T, TResult> Decorate<T, TResult>(Func<T, TResult> function)
//        {
//            var cache = new Dictionary<T, TResult>();
//            return x =>
//            {
//                if (!cache.ContainsKey(x))
//                {
//                    cache.Add(x, function(x));
//                }
//                return cache[x];
//            };
//        }
//    }

//    public class TestClass
//    {
//        public Func<int, int> doadd;
//        public TestClass()
//        {
//            doadd = CacheProvider.Decorate<int, int>(add);
//        }
//        public int add(int num)
//        {
//            return num * 10;
//        }
//    }
//}
