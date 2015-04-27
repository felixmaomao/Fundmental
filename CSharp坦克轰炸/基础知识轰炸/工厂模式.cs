//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //这个例子我们将阐释 什么是工厂模式，以及为什么要使用工厂模式

//    class 工厂模式
//    {
//        public static void Main(string[] args)
//        {
//            CarFactory fac = new CarFactory();
//            Car c = fac.CreateCar("BMW",30);
            
//        }
//    }

//    class Car
//    {
//        private string Logo;
//        private int Money;
//        public Car(string logo,int money)
//        {
//            this.Logo = logo;
//            this.Money = money;
//        }
//    }
//    class CarFactory
//    {
//        public Car CreateCar(string logo,int mon)
//        {
//            return new Car(logo,mon);
//        }
//    }
//}
