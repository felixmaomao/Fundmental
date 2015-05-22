//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //看真正的好代码可以学到东西。也能感觉到学海无涯
//    class Activator相关
//    {
//        public static void Main(string[] args)
//        {
//            object o = Activator.CreateInstance(typeof(StringBuilder));
//            StringBuilder s=(StringBuilder)o;
//            s.Append("wokao");
//            Console.WriteLine(s.ToString());
//            object m = Activator.CreateInstance(typeof(Man));
//            Man man = (Man)m;
//            man.name = "shenwei";
//            man.sex = "男";
//            Console.WriteLine(man.name+man.sex);
//            Console.ReadKey();

//        }
//    }
//    class Man
//    {
//        public string name;
//        public string sex;
//    }
//}
