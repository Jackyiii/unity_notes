using System;

namespace 练习匿名函数 {
    public delegate bool Del1(bool b);
    class MainClass {
        public static void Main(string[] args) {
            Del1 b=delegate(bool isb){
                return isb;
	        };
            bool testb = b(true);
        }
    }
}
