//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.IO;
//namespace 基础知识轰炸
//{
//    //好吧 既然是轰炸，那我们就不偷懒，老老实实把书上的代码模拟一遍
//    delegate void FeedBack(Int32 val);
//    class 委托一
//    {
//        public static void Main(string[] args)
//        {
//            //StaticDelegateDemo();
//            //InstanceDelegateDemo();
//            //DlegateChainDemo1();
//            DelegateChainDemo2();
//            Console.ReadKey();
//        }

//        private static void StaticDelegateDemo()
//        {
//            Counter(1,10,null);
//            Counter(1,20,new FeedBack(FeedBackToConsole));
//            Counter(1,5,new FeedBack(FeedBackToMsgBox));           
//        }
//        private static void InstanceDelegateDemo()
//        {
//            委托一 foo = new 委托一();
//            Counter(1,10,foo.FeedBackToFile);

//        }
//        //委托链,眼高手低，真正上手写又不会了
//        private static void DlegateChainDemo1()
//        {
//            FeedBack fb1 = new FeedBack(FeedBackToConsole);
//            FeedBack fb2 = new FeedBack(FeedBackToMsgBox);
//            FeedBack fb3 = new FeedBack(new 委托一().FeedBackToFile);
//            FeedBack chain = null;
//            chain = (FeedBack)Delegate.Combine(chain,fb1);
//            chain = (FeedBack)Delegate.Combine(chain,fb2);
//            chain = (FeedBack)Delegate.Combine(chain,fb3);
//            Counter(1,10,chain);            
//        }
//        private static void DelegateChainDemo2()
//        {
//            FeedBack fb1 = new FeedBack(FeedBackToConsole);
//            FeedBack fb2 = new FeedBack(FeedBackToMsgBox);
//            FeedBack fb3 = new FeedBack(new 委托一().FeedBackToFile);
//            FeedBack chain = null;
//            chain += fb1;
//            chain += fb2;
//            chain += fb3;
//            Counter(1,5,chain);
//        }
//        private static void Counter(Int32 from,Int32 to,FeedBack fb)
//        {
            
//            for (int i = from; i < to;i++ )
//            {
//                if(fb!=null)
//                {
//                fb(i);
//                }
//            }            
//        }
//        private static void FeedBackToConsole(Int32 val)
//        {
//            Console.WriteLine("Item="+val);
//        }
//        private static void FeedBackToMsgBox(Int32 val)
//        {
//            MessageBox.Show("Item="+val);
//        }
//        private void FeedBackToFile(Int32 val)
//        {
//            using(StreamWriter sw=new StreamWriter("status",true))
//            {
//                sw.WriteLine("Item="+val);
//            }
//        }

//    }


//}
