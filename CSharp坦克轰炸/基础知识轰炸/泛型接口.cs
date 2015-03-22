//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{
//    class 泛型接口
//    {
//        public static void Main(string[] args)
//        {
//            Fighter fighter = new Fighter();
//            Console.WriteLine("the damage of the fighter is:"+fighter.weapon.damage);
//            fighter.weapon.Attack();

//            Console.WriteLine("=========");
//            GenericFighter<IronSward> gfighter = new GenericFighter<IronSward>();
//            gfighter.weapon = new IronSward();
//            gfighter.weapon.Attack();
//            Console.ReadKey();
//        }
//    }

//    public interface IFight<T>
//    {
//        T weapon
//        {
//            get;
//            set;
//        }
//    }

//    public interface IWeapon
//    {
//        int damage
//        {
//            get;
//            set;
//        }
//        void Attack();
//    }

//    public class IronSward : IWeapon
//    {
//        private int _damage=200;
//        public int damage
//        {
//            get
//            {
//                return _damage;
//            }
//            set
//            {
//                _damage = value;
//            }
//        }

//        public void Attack()
//        {
//            Console.WriteLine("---Cause damage"+damage);
//        }
//    }

//    public class Fighter : IFight<IronSward>
//    {
//        private IronSward _sward=new IronSward();
//        public IronSward weapon
//        {
//            get{return _sward;}
//            set{_sward=value;}
//        }
//    }

//    //这里可以加上一些约束
//    public class GenericFighter<T> : IFight<T> where T:IWeapon
//    {
//        private T _weapon;
//        public T weapon
//        {
//            get
//            {
//                return _weapon;
//            }
//            set
//            {
//                _weapon = value;
//            }
//        }
//    }
//}
