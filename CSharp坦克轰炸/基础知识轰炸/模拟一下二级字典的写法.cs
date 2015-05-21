//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    class 模拟一下二级字典的写法
//    {
//        public static Dictionary<string, ILookup<string, Person>> _cache = new Dictionary<string, ILookup<string, Person>>();
//        public static void Main(string[] args)
//        {
//            List<Person> persons = new List<Person>();
//            persons.Add(new Person("shenwei", "jiangsu"));
//            persons.Add(new Person("shenwei", "henan"));
//            persons.Add(new Person("shenwei", "beijing"));
//            persons.Add(new Person("zhangxiaomao", "jiangsu"));
//            persons.Add(new Person("zhangxiaomao", "shanghai"));
//            persons.Add(new Person("zhangliyi", "henan"));
//            persons.Add(new Person("daxiong", "shanghai"));
//            persons.Add(new Person("xiaoxiong","shanghai"));

//            var groupbyname = persons.GroupBy(p=>p.name);
//            _cache = groupbyname.ToDictionary(
//                      g=>g.Key,
//                      g=>g.ToLookup(p=>p.address)
//                );

//            //下面使用找人方法,寻找 河南和江苏的shenwei
//            HashSet<string> addresses = new HashSet<string>();
//            addresses.Add("jiangsu");
//            addresses.Add("henan");
//            ICollection<Person> find = GetPerson("shenwei",addresses);
//            foreach(Person p in find)
//            {
//                Console.WriteLine(p.name);
//                Console.WriteLine(p.address);
//            }
//            //这样子分成字典有什么好处呢？你可能会愚蠢的问。很明显，如果不分字典进行查找的话，那么会需要完全遍历，当数据量大的时候会相当耗时。
//            //这样分成字典之后，查找起来就像显示生活中查字典一样 相当轻便了。 
//            Console.ReadKey();
//        }
//        public static ICollection<Person> GetPerson(string name,HashSet<string> addresses)
//        {
//            HashSet<Person> matches = new HashSet<Person>();
//            ILookup<string, Person> addrlookup;
//            if(_cache.TryGetValue(name,out addrlookup))
//            {
//                if (addresses != null)
//                {
//                    foreach (string requestedaddress in addresses)
//                    {
//                        foreach (var groupaddress in addrlookup)
//                        {
//                            if (requestedaddress.Equals(groupaddress.Key))
//                            {
//                                matches.UnionWith(groupaddress);
//                            }
//                        }
//                    }
//                }
//                else
//                {
//                    foreach(var groupaddress in addrlookup)
//                    {
//                        matches.UnionWith(groupaddress);
//                    }
//                }
//            }
//            return matches;
//        }

//    }
//    class Person
//    {
//        public string name;
//        public string address;
       
//        public Person(string name, string address)
//        {
//            this.name = name;
//            this.address = address;
          
//        }
//    }
//}
