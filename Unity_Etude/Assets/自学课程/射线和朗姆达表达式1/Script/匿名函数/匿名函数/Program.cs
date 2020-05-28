using System;

namespace 匿名函数 {
    public delegate int Del(int a,int b);
    class MainClass {
        public static void Main(string[] args) {
            int num=Test1(delegate(int a,int b) { return a - b; },4,6);
            Console.WriteLine(num);
        }
        public static int Test1(Del del,int a,int b) {
            return del(a,b);
        }
    }
}
