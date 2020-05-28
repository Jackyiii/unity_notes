using System;

namespace DelegateAppli {
    public delegate void Dele();
    class MainClass {
        public static void Main(string[] args) {
            Student st = new Student();
            Teacher t = new Teacher();
            t.Daling(st.Eat);
            t.Daling(st.PlayGame);
        }
    }
    public class Student {
        public void PlayGame() {
            Console.WriteLine("play");
        }
        public void Eat() {
            Console.WriteLine("eat");
        }
    }
    public class Teacher {
        public void Daling(Dele del) {
            del();
        }
    }

}
