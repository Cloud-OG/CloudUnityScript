using UnityEngine;
using System;
using System.Collections.Generic;
//单例模式
public class Worker
{
    //员工姓名
    public String name;                         
}
public class Leader 
{
    public String name;
    private static Leader instance = null;
    private List<Worker> workers = new List<Worker>(); 
    
    //私有化构造方法，防止外界实例化该对象
    private Leader(){}
    
    //给外界开放一个接口，用于访问唯一的领导对象
    public static Leader Instance
    {
        //若对象为空，则实例化一个领导对象
        get { return instance ??= new Leader(); }
    }
    
    //添加员工
    public void AddWorker(String workerName)
    {
        //创建一个员工对象
        Worker worker = new Worker();
        //设置员工名称
        worker.name = workerName;
        //将员工添加到员工数组中
        workers.Add(worker);
    }
    //查看员工
    public void Check()
    {
        foreach (Worker worker in workers)
        {
            //输出员工姓名
            Debug.Log(worker.name);
        }    
    }
}
public class SingletonTest : MonoBehaviour
{
    //SingletonTest是继承MonoBehaviour的组件类,能够调用组件中的所有公共属性、方法和字段
    //由于我们控制不了组件类的实例化过程，因此就要使用下述方法将其设置为单例类
    public static SingletonTest instance;
    private void Awake()
    {
        instance=this;
    }

    void Start()
    {   
        Leader.Instance.AddWorker("MiKaSa");
        Leader.Instance.AddWorker("Alan");
        Leader.Instance.Check();
    }
    // Update is called once per frame
}
