using System;

namespace 范型 {
    class MainClass {
        public static void Main(string[] args) {
            Person p = new Person();
            int a=p.GetTemp<int>(3, 5);
            Console.WriteLine(a);
        }
    }

    //where表示范型的约束T: struct 值类型的类型
    //自定义范型的约束 T:struct 限定T类型只能为值类型
    //                Q:class 限定类型只能为引用类型
    //                O:ICloneable只能是ICloneable的子类
    //                K:P 只能是P类或者子类类型
    //                W:class,new()限定W类型是引用类型，并且使用了无参构造函数


    public class Person {
        public T GetTemp<T>(T a,T b) where T: struct
        {
            T temp = a;
            a = b;
            b = temp;
            return temp;
        }
    }
}
