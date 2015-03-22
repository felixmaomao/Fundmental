//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    class 继承小测试
//    {
//        public static void Main(string[] args)
//        {
//            //继承的确可以获得父类的绝大部分东西，但是对于任何私有的东西就没有办法继承下来，很合理。
//            MyClass myclass = new MyClass();
//            myclass.sayhi();
//            Console.ReadKey();
//        }
//    }

//    class YourClass
//    {
//        private string Name;
//        public string Text;
//        public void sayhi()
//        {
//            Console.WriteLine("Hi");
//        }
//        private void sayHello()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//    class MyClass : YourClass
//    {
//        //没有任何代码
//    }
//}
