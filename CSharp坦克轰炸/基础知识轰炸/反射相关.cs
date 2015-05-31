using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace 基础知识轰炸
{
    //有时候看网上的一些博客或者文库去了解一个知识点 确实会来的更快更直接

    //.net程序有几个部分组成 程序集 assembly  模块module 类型 class
    //assembly 可以获得它里面的类型的Type信息， 而type可以获得对象类型信息 
    //MethodInfo指的是相关的方法信息。同样 还有 FieldInfo，ConstructorInfo, PropertyInfo 等
    //而这些东西之间是相互关联的很紧密的。
    class 反射相关
    {
        public static void Main(string[] args)
        {
            classA a = new classA();
            TestObjectType t = new TestObjectType();
            t.testype(a);
        }
    }

    class classA
    {
        public int iNumberA = 100;
        public int INumberB = 200;
        public int property;
        public int Property
        {
            get { return property; }
            set { property = value; }
        }
        public void FunA()
        {
            Console.WriteLine("function a in classA");
        }
    }
    class TestObjectType
    {
        public void testype(object a)
        {
            Type typeA = a.GetType();
            Assembly objassembly = typeA.Assembly;
            Type[] allTypes = objassembly.GetTypes();
            foreach(Type type in allTypes)
            {
                //获取类型名
                Console.WriteLine("类名："+type.FullName);
                //获取类型的构造xinxi
                ConstructorInfo[] myConstructor = type.GetConstructors();
                show(myConstructor);
                //获取类型的字段信息
                FieldInfo[] myfield = type.GetFields();
                show(myfield);
                //获取类型的属性信息
                PropertyInfo[] myproperty = type.GetProperties();
                show(myproperty);
                //获取类型的方法信息
                MethodInfo[] mymethod = type.GetMethods();
                show(mymethod);
            }
            Console.ReadKey();
        }

        public void show(object[] objs)
        {
            foreach(object o in objs)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("---------");
        }
    }

}
