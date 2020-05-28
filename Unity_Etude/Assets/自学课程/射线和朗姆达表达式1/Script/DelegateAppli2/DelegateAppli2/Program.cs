using System;

namespace DelegateAppli2 {
    public delegate string Dele(string str);
    public delegate string Dele2(string str);
    class MainClass {
        public static void Main(string[] args) {
            Dele del = toLower;
            string s=del("FEIYI");
            Console.WriteLine(s);
            string s1=Test(toLower, "YIYI");
            Console.WriteLine(s1);
        }
        public static string toUpper(string str) {
            return str.ToUpper();
        }
        public static string toLower(string str) {
            return str.ToLower();
        }
        public static string Test(Dele2 del,string str) {
            return del(str);
        }
    }
}
