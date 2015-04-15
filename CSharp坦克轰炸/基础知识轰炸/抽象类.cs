//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //总结一下：抽象类 和接口都是类的抽象，接口更关注从行为方面来抽象，而在语法上 接口的内容必须都是没有实现的，完全等待后面的类来实现的
//    //而在这一点上，抽象类则像是一个没有完全实现的类，他想所有普通类一样，可以拥有字段，属性，以及方法，这些都是可以有具体实现体的，
//    //但就这样的话，他和普通类的差别只在于他不可以通过new实例化，而他的真正不同在于 他应该有abstract修饰的部分，这部分没有具体实现，必须由
//    //由后面的实现类来具体实现。
//    //而virtual关键字本不该属于这里的讨论范畴，他修饰的方法和普通方法几乎一样，都是有着方法体的，但是被virtual修饰的可以被子类重写。
//    class 抽象类
//    {
//        public static void Main(string[] args)
//        {
//            ChinesePerson c = new ChinesePerson("沈伟", 23);
//            c.Run();
//            c.Speak();
//            Console.WriteLine(c.Name);
//            Console.WriteLine(c.Age);
//            Console.WriteLine(c.Hobby);
//            Console.WriteLine("--------");
//            c.fight();
//            JiangSuPerson j = new JiangSuPerson();
//            j.Name = "zhangxiaomao";
//            j.Age = 24;
//            j.Run();
//            j.Speak();
//            j.fight();
//            j.sing();
//            Console.WriteLine(j.Name);
//            Console.WriteLine(j.Age);
//            Console.WriteLine(j.Hobby);
//            Console.WriteLine("----------");
//            HenanPerson h = new HenanPerson();
//            h.Name = "zhanglinyi";
//            h.Speak();
//            h.fight();
//            h.sing();
//            Console.ReadKey();
//        }
//    }

//    public interface IRun
//    {
//        void Run();
//    }

//    //可以把抽象类理解成为一个不完整的类，他存在着不确定的抽象部分，其他的和普通的类基本是一样的，他不可以被实例化
//    //他也可以不存在抽象的部分，不过这样就没有必要定义成抽象类了（语法上是成功的）。
//    // 只有属性和方法可以是abstract的,抽象类也是可以有构造函数的，只不过这个构造函数不能用来new创建实例。
//    public abstract class Person : IRun
//    {
//        private string name;
//        private int age;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public int Age
//        {
//            get { return age; }
//            set { age = value; }
//        }
//        public abstract string Hobby { get; set; }
//        public Person(string name, int age)
//        {
//            this.Name = name;
//            this.Age = age;
//        }
//        public Person()
//        { }
//        public abstract void Speak();
//        public void Run()
//        {
//            Console.WriteLine("Running ~~");
//        }
//        //能够被子类重写的 只有 abstract 或virtual修饰的，
//        //不同在于，abstract一定要被重写，而virtual则是可以被重写 但不一定非要重写，还有就是virtual要有方法体。
//        public virtual void fight()
//        {
//            Console.WriteLine("fighting");
//        }
//    }
//    public class ChinesePerson : Person
//    {

//        public ChinesePerson(string name, int age)
//            : base(name, age)
//        {
//            this.Name = name;
//            this.Age = age;
//        }
//        public ChinesePerson()
//        {
//        }
//        public override void Speak()
//        {
//            Console.WriteLine("中国人说中文");
//        }

//        public override string Hobby
//        {
//            get
//            {
//                return "shopping";
//            }
//            set
//            {
//            }
//        }
//        public override void fight()
//        {
//            base.fight();
//            Console.WriteLine("chinese gongfu fighting");
//        }
//        public virtual void sing()
//        {
//            Console.WriteLine("用中文唱歌");
//        }
//    }

//    //继承自中国人,但是没有任何重写
//    public class JiangSuPerson : ChinesePerson
//    {

//    }
//    public class HenanPerson : ChinesePerson
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("河南人说河南方言");
//        }
//        public override void sing()
//        {
//            Console.WriteLine("用河南话唱歌");
//        }
//    }

//}
