//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    class 面向对象动物世界大战
//    {
//        //这是程序的演示世界
//        public static void Main(string[] args)
//        {
//            Swan swan = new Swan();
//            swan.Weight = 20;
//            Swan swan2 = new Swan();
//            swan2.Weight = 50;
//            Lion lion = new Lion();
//            lion.Weight = 50;
//            Lion lion2 = new Lion();
//            lion2.Weight = 40;
//            //现在我们要找到重量大于50的参加战斗， 就先把这些全部装入抽象集合
//            IFight[] fighters = new IFight[] {swan,swan2,lion,lion2 };
//            Console.WriteLine("我们总共募集了");
//            Console.WriteLine( fighters.Count());
//            Console.WriteLine("现在人数多了 我们招体重50以上的");
//            foreach(IFight i in fighters)
//            {
//                if(i.Weight>=50)
//                {
//                    Console.WriteLine("这个战士要了");
//                }
//            }            
//            Console.ReadKey();
//        }
//    }

//    //我们先抽象出动物种族,我们认为 有很高体重能吃能睡暂且就属于动物了
//    abstract class Animal
//    {
//        //抽象类只能有抽象属性和抽象方法 不能有字段
//        public abstract int Weight
//        {
//            get;
//            set;
//        }
//        public abstract int Height
//        {
//            get;
//            set;
//        }
//        public abstract void Eat();
//        public abstract void Sleep();
//    }

//    //我们再抽象出会飞的动物
//    abstract class FlyAnimal : Animal
//    {
//        public abstract void Fly();
//        //在抽象类中也可以有对上层抽象的重写具体实现
//        public override void Sleep()
//        {
//            Console.WriteLine("在树上睡觉");
//        }
//    }

//    //会游泳的动物
//    abstract class SwimAnimal:Animal
//    {
//        public abstract void Swim();
//    }

//    //会跑的动物
//    abstract class RunningAnimal : Animal
//    {
//        public abstract void Run();        
//    }

//    //定义一个狮子继承
//    class Lion : RunningAnimal,IFight
//    {
//        public override void Run()
//        {
//            Console.WriteLine("Lion Running.. ");
//        }

//        public override void Eat()
//        {
//            Console.WriteLine("Lion Eating..") ;
//        }

//        public override void Sleep()
//        {
//            Console.WriteLine("Lion Sleeping");
//        }

//        public override int Weight
//        {
//            get;
//            set;
//        }

//        public override int Height
//        {
//            get;
//            set;
//        }

//        public void run30kmfast()
//        {
//            Console.WriteLine("run30kmfast");
//        }

//        public void take30kgsward()
//        {
//            Console.WriteLine("take30kgsward");
//        }
//    }

//    //定义一个天鹅
//    class Swan : FlyAnimal,IFight
//    {
//        public override void Fly()
//        {
//            Console.WriteLine("飞");
//        }

//        public override int Weight
//        {
//            get;
//            set;
//        }

//        public override int Height
//        {
//            get;
//            set;
//        }

//        public override void Eat()
//        {
//            Console.WriteLine("吃。。");
//        }
//        public override void Sleep()
//        {
//            //可以保留父类的实现，也可以不保留
//            //base.Sleep();
//            Console.WriteLine("也可以在水里睡觉");
//        }
//        public void run30kmfast()
//        {
//            Console.WriteLine("run30kmfast");
//        }

//        public void take30kgsward()
//        {
//            Console.WriteLine("take30kgsward");
//        }
//    }

//    //战斗接口
//    public interface IFight
//    {
//        int Weight { get; set; }
//        int Height { get; set; }
//        void run30kmfast();
//        void take30kgsward();
//    }



//}
