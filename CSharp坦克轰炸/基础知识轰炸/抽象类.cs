using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础知识轰炸
{
    class 抽象类
    {
        public static void Main(string[] args)
        {
            ChinesePerson c = new ChinesePerson("沈伟",23);          
            c.Run();            
            c.Speak();
            Console.WriteLine(c.Name);
            Console.WriteLine(c.Age);
            Console.WriteLine(c.Hobby);
            Console.WriteLine("--------");
            JiangSuPerson j = new JiangSuPerson();
            j.Name = "zhangxiaomao";
            j.Age = 24;
            j.Run();
            j.Speak();
            Console.WriteLine(j.Name);
            Console.WriteLine(j.Age);
            Console.WriteLine(j.Hobby);
            Console.ReadKey();
        }
    }

    public interface IRun
    {
        void Run();
    }

    //可以把抽象类理解成为一个不完整的类，他存在着不确定的抽象部分，其他的和普通的类基本是一样的，他不可以被实例化
    //他也可以不存在抽象的部分，不过这样就没有必要定义成抽象类了（语法上是成功的）。
    // 只有属性和方法可以是abstract的,抽象类也是可以有构造函数的，只不过这个构造函数不能用来new创建实例。
    public abstract class Person : IRun
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public abstract string Hobby { get; set; }
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person()
        { }
        public abstract void Speak();
        public void Run()
        {
            Console.WriteLine("Running ~~");
        }
    }
    public class ChinesePerson : Person
    {
     
        public ChinesePerson(string name,int age):base(name,age)
        {
            this.Name = name;
            this.Age = age;
        }
        public ChinesePerson()
        {
        }
        public override void Speak()
        {
            Console.WriteLine("中国人说中文");
        }

        public override string Hobby
        {
            get
            {
                return "shopping";
            }
            set
            {
            }
        }
    }

    //继承自中国人,但是没有任何重写
    public class JiangSuPerson:ChinesePerson
    {
        
    }

}
