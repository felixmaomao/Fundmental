//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //相当好的一个例子
//    class 字典以及序列化等常用
//    {
//        public static void Main(string[] args)
//        {
//            School s = new School();
//            s.EnsureInitialized();
//            s.fillCache();
//            HashSet<string> places=new HashSet<string>();
//            places.Add("江苏");
//            places.Add("河南");
//            ICollection<Person> find=s.FindPerson("shenwei",places,IsComputer);
//            foreach(Person p in find)
//            {
//                Console.WriteLine(p.Name);
//                Console.WriteLine(p.Province);
//                Console.WriteLine(p.sex);
//                Console.WriteLine(p.Depart);
//            }
//            Console.ReadKey();

//        }
//        public static bool IsMan(Person p)
//        {
//            return p.sex == "男";
//        }
//        public static bool IsComputer(Person p)
//        {
//            return p.Depart == "计算机";
//        }
//    }

//    public  class Person
//    {
//        public string Name;
//        public string Province;
//        public string sex;
//        public string Depart;
//        public Person(string name,string pro,string sex,string depa)
//        {
//            this.Name = name;
//            this.Province = pro;
//            this.sex = sex;
//            this.Depart = depa;
//        }
//    }
//    public class School
//    {
//        public List<Person> students = new List<Person>();
//        public void EnsureInitialized()
//        {
//            students.Add(new Person("shenwei","江苏","男","计算机"));
//            students.Add(new Person("shenwei", "河南", "男", "建筑"));
//            students.Add(new Person("shenwei", "江苏", "女", "建筑"));
//            students.Add(new Person("zhangxiaomao", "江苏", "女", "纺织"));
//            students.Add(new Person("zhanglinyi", "河南", "男", "计算机"));
//            students.Add(new Person("zhangjiahao", "河南", "男", "数学"));
//            students.Add(new Person("zhanglinyi", "江苏", "女", "电子"));
//            students.Add(new Person("shenjiaju", "江苏", "男", "英语"));
//            students.Add(new Person("zhanghan", "河南", "男", "机械"));
//        }
//        public Dictionary<string, ILookup<string, Person>> _cache = new Dictionary<string, ILookup<string, Person>>();
//        public void fillCache()
//        {
//            var groupbyname = students.GroupBy(s=>s.Name);
//            _cache = groupbyname.ToDictionary(
//                g=>g.Key,
//                g=>g.ToLookup(p=>p.Province)
//                );
//        }
//        //相当复杂的寻人方法。
//        public ICollection<Person> FindPerson(string name,HashSet<string> provinces,Predicate<Person> predict)
//        {
//            HashSet<Person> matches = new HashSet<Person>();
//            ILookup<string, Person> prolookup;
//            if(_cache.TryGetValue(name,out prolookup))
//            {
//                if (provinces != null)
//                {
//                    foreach (string requestedProvince in provinces)
//                    {
//                        foreach (var pro in prolookup)
//                        {
//                            if (pro.Key.Equals(requestedProvince))
//                            {
//                                if (predict == null)
//                                {
//                                    matches.UnionWith(pro);
//                                }
//                                else
//                                { 
//                                    HashSet<Person> temp=new HashSet<Person>();
//                                    foreach(var p in pro)
//                                    {
//                                        if (predict(p))
//                                        {
//                                            temp.Add(p);
//                                        }
//                                    }
//                                    matches.UnionWith(temp);
//                                }
                                
//                            }
//                        }
//                    }
//                }
//                else
//                {
//                    foreach (var pro in prolookup)
//                    {
//                        if (predict == null)
//                        {
//                            matches.UnionWith(pro);
//                        }
//                        else
//                        {
//                            HashSet<Person> temp = new HashSet<Person>();
//                            foreach (var p in pro)
//                            {
//                                if (predict(p))
//                                {
//                                    temp.Add(p);
//                                }
//                            }
//                            matches.UnionWith(temp);
//                        }                       
//                    }
//                }
//            }
//            return matches;
//        }
//    }
//}
