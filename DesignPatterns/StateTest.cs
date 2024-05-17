using UnityEngine;
using System;
//状态模式

public abstract class State
{
    //每个状态都要实现的抽象方法
    public abstract void Run();
}
//睡觉状态
public class SleepState : State
{
    public override void Run()
    {
        Debug.Log("睡觉操作");
    }
}
//娱乐状态
public class PlayState : State
{
    public override void Run()
    {
        Debug.Log("娱乐操作");
    }
}
//学习状态
public class StudyState : State
{
    public override void Run()
    {
        Debug.Log("学习操作");
    }
}

public class Student
{
    public String name;
    //每个学生都有一个当前状态
    public State state;
    public void Run(int time)
    {
        if (time>=22||time<=7)
        {
            state = new SleepState();
        }
        else if (time>7&&time<18)
        {
            state = new StudyState();
        }
        else
        {
            state = new PlayState();
        }
        state.Run();
    }
}
public class StateTest : MonoBehaviour
{
    void Start()
    {
        Student student = new Student();
        student.Run(11);
        student.Run(22);
    }
}
