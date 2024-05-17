using UnityEngine;
using System;
//外观模式
public class StudentSystem
{
    public void Run()
    {
        Debug.Log("StudentSystem");
    }
}

public class TeacherSystem
{
    public void Run()
    {
        Debug.Log("TeacherSystem");
    }
}

public class WorkerSystem
{
    public void Run()
    {
        Debug.Log("WorkerSystem");
    }
}

public class Facade
{
    //三个系统
    StudentSystem studentSystem;
    TeacherSystem teacherSystem;
    WorkerSystem workerSystem;
    //初始化三个系统
    public Facade()
    {
        studentSystem = new StudentSystem();
        teacherSystem = new TeacherSystem();
        workerSystem = new WorkerSystem();
    }
    public void StudentRun()
    {
        studentSystem.Run();
    }

    public void TeacherRun()
    {
        teacherSystem.Run();
    }

    public void WorkerRun()
    {
        workerSystem.Run();
    }
}

public class FacadeTest : MonoBehaviour
{
    private void Start()
    {
        Facade facade = new Facade();
        facade.StudentRun();
        facade.TeacherRun();
    }
}
