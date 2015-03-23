//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //比较简单的泛型只有一个类型参数，比较复杂的泛型就可能有多个类型参数
//    //二次约束就是指所提供的两个类型参数之间有约束
//    class 泛型约束次级约束
//    {
//        public static void Main(string[] args)
//        {
//            MyDic<string, string> dic = new MyDic<string, string>();
//            dic.Add("shenwei","zhangxiaomao");
//            dic.Add("xiayu","shihuimin");
//            dic.Add("wanghaiwei","hahaha");
//            dic.Add("shenfei","moumou");
//            Console.WriteLine(dic.ToString());
//            Console.ReadKey();
            
//        }
//    }

//    class MyDic<TKey, TValue>
//    {
//        private Dictionary<TKey, TValue> _dic=new Dictionary<TKey,TValue>();
//        public void Add(TKey key,TValue val)
//        {
//            _dic.Add(key,val);
//        }
//        public override string ToString()
//        {
//            StringBuilder builder = new StringBuilder();
//            foreach(KeyValuePair<TKey,TValue> pair in _dic)
//            {
//                builder.Append("key:"+pair.Key);
//                builder.Append("value:"+pair.Value);
//            }
//            return builder.ToString();
//        }
//    }

//}
