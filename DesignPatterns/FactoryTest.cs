using UnityEngine;
//工厂模式

public abstract class Car
{
    public abstract void Run();
}
public class Bmw : Car
{
    public override void Run()
    {
        Debug.Log("宝马");
    }
}
public class Audi : Car
{
    public override void Run()
    {
        Debug.Log("奥迪");
    }
}
public class Benz : Car
{
    public override void Run()
    {
        Debug.Log("奔驰");
    }
}
public enum CarType
{
    Bmw,
    Audi,
    Benz
}
public class Factory
{
    public static Car Create(CarType carType)
    {
        Car car = null;
        switch (carType)
        {
            case CarType.Bmw:
                car = new Bmw();
                break;
            case CarType.Audi:
                car = new Audi();
                break;
            case CarType.Benz:
                car = new Benz();
                break;
        }
        return car;
    }
}
public class FactoryTest : MonoBehaviour
{
    void Start()
    {
        //不使用工厂模式，初始化一个对象需要记忆对象的类名
        // Car car1 = new Audi();
        // Car car2 = new Bmw();
        // Car car3 = new Benz();
        
        //使用工厂模式，在初始化时，只需要工厂类调用创建对象的静态方法
        //再通过静态方法的枚举参数的代码提示，可以直观地显示出所有的类
        //省去了想要使用某个类时的需要类名的记忆过程
        
        Car car1 = Factory.Create(CarType.Audi);
        Car car2 = Factory.Create(CarType.Bmw);
        Car car3 = Factory.Create(CarType.Benz);
        
        car1.Run();
        car2.Run();
        car3.Run();
    }
}
