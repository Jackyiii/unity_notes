
using System;
using UnityEngine;

public enum DoSth {
    playGame,
    chat,

}
class Program {
    static void Main(string[] args) {
        Teacher t = new Teacher();
        t.Daling(DoSth.chat);
        Console.ReadKey();
    }
}

public class Student {
    public void PlayGame() {
        Debug.Log("Play");
    }
    public void Chat() {
        Debug.Log("和妹子聊天");
    }
}
public class Teacher{
    //给打铃一个状态，然后调用相应的方法
    public void Daling(DoSth dt) {
        Student st = new Student();
        switch(dt) {
            case DoSth.playGame:
                st.PlayGame();
                break;
            case DoSth.chat:
                st.Chat();
                break;
        }
    }
}
