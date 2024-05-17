using System.Collections.Generic;
using UnityEngine;
//观察者模式

//观察者接口
public interface IViewer
{
    void Run();
}
//观察者(们)只需要明确各自的反应即可（所需要调用的元素）
public class Viewer1 : IViewer
{
    public void Run()
    {
        Debug.Log("Laugh");
    }
}
public class Viewer2 : IViewer
{
    public void Run()
    {
        Debug.Log("Cry");
    }
}
public class Viewer3 : IViewer
{
    public void Run()
    {
        Debug.Log("Shout");
    }
}
public class Subject
{
    //监听的观众
    private readonly List<IViewer> viewers = new List<IViewer>();
    
    //添加观察者
    public void Add(IViewer viewer)
    {
        viewers.Add(viewer);
    }
    //移除观察者
    public void Remove(IViewer viewer)
    {
        viewers.Remove(viewer);
    }
    ///对于被观察者来说，它不需要知道观察者是谁，观察者里面有什么，
    ///只需要对其一致地、不加以区分地对其进行调用

    //调用观察者的方法
    public void RunViewers()
    {
        foreach (IViewer viewer in viewers)
        {
            viewer.Run();
        }
    }
}
//观察者与被观察者各司其职，从而降低代码的耦合度，方便后期修改
public class ObserverTest : MonoBehaviour
{
    Subject subject;
    void Start()
    {
        //初始化被观察对象
        subject = new Subject();
        //实例化三名观察者
        subject.Add(new Viewer1());
        subject.Add(new Viewer2());
        subject.Add(new Viewer3());
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            subject.RunViewers();
        }
    }
}
