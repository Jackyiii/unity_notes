using System;

namespace LamdaTest {
    public delegate void Dele();
    public delegate void Dele1(string name);
    public delegate string Dele2(string name);
    public delegate bool Dele3(bool b1);
    class MainClass {
        public static void Main(string[] args) {
            //委托
            Dele del0 = delegate(){ };
            //Lamda =>指向后面的方法体
            Dele1 del1 = (name) => { };
            Dele2 del2 = (name) => { return name; };
            Dele3 del3 = (bo) => { return bo; };


        }
    }
}
