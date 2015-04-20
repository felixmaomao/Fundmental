//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    //大致模拟了MVC框架中的控制器模块的思想
//    class 抽象类二
//    {
//        public static void Main(string[] args)
//        {
//            IController ic;
//            ic = new HomeController();
//            ic.Execute();
//            Console.ReadKey();
//        }
//    }

//    public interface IController
//    {
//        void Execute();
//    }

//    public abstract class ControllerBase : IController
//    {
//        //可以选择性的重写这整个方法，而不按照所期望的分步骤
//        //这边把一个方法拆分为二的思想可以借鉴
//        public virtual void Execute()
//        {
//            Console.WriteLine("doing some unimporting things");
//            ExecuteCore();
//        }
//        //这个方法则必须实现
//        public abstract void ExecuteCore();
//    }
//    public abstract class Controller : ControllerBase
//    {
//        public override void ExecuteCore()
//        {
//            Console.WriteLine("doing some importing things");
//        }

//        //public override void Execute()
//        //{
//        //    Console.WriteLine("doing the whole things");
//        //}
//    }
//    public class HomeController : Controller
//    {

//    }
//}
