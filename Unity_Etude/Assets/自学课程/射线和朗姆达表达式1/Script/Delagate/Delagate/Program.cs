using System;
//委托
namespace Delagate {
    //定义委托----签名保持一致 签名，返回值类型和参数列表
    //定义委托类型的变量
    //给委托赋值可以说绑定方法
    //调用
    public delegate void Dele();

    class MainClass {
        public static void Main(string[] args) {
            //委托是方法的类型，可以传参传入函数
            //关键词delegate
            //定义委托类型的变量
            Student st = new Student();
            Dele del = st.Drink;
            //调用委托
            del();
            del += st.Eat;
            del();
            Console.ReadKey();
        }
    }
    public class Student {
        public void Eat() {
            Console.WriteLine("eat");
        }
        public void Drink() {
            Console.WriteLine("drink");
        }
    }
}
