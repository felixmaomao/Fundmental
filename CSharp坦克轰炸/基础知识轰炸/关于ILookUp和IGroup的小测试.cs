//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //不同点应该在于 一个是立即执行 而另一个是延迟执行。
//    class 关于ILookUp和IGroup的小测试
//    {
//        public static void Main(string[] args)
//        {
//            List<Person> persons = new List<Person>();
//            persons.Add(new Person("shen","wei"));
//            persons.Add(new Person("zhang","xiaomao"));
//            persons.Add(new Person("shen","jiaju"));
//            persons.Add(new Person("zhang","linyi"));
//            persons.Add(new Person("da","xiong"));

//            var q1 = persons.GroupBy(p=>p.firstname);
//            var q2 = persons.ToLookup(p=>p.firstname);
            
//            //在这里我们在针对persons进行操作
//            persons.Add(new Person("xiao","xiong"));
//            Console.WriteLine(q1.Count());
//            Console.WriteLine(q2.Count);

//            foreach(var g in q1)
//            {
//               foreach(var q in g)
//               {
//                   Console.WriteLine(q.firstname);
//                   Console.WriteLine(q.lastname);
//               }
//            }
//            Console.WriteLine("---------------");
//            foreach(var g in q2)
//            {
//                foreach(var q in g)
//                {
//                    Console.WriteLine(q.firstname);
//                    Console.WriteLine(q.lastname);
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//    class Person
//    {
//        public string firstname;
//        public string lastname;
//        public Person(string fir,string las)
//        {
//            firstname = fir;
//            lastname = las;
//        }
//    }
//}
