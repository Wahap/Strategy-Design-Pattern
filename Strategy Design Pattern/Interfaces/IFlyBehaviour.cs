using System;

namespace Strategy_Design_Pattern
{
  public interface IFlyBehaviour
  {
    void Fly();
  }

  public class NotFly : IFlyBehaviour
  {
    public void Fly()
    {
     Console.WriteLine("It can not fly");
    }
  }

  public class FlyWithWings : IFlyBehaviour
  {
    public void Fly()
    {
      Console.WriteLine("it flys with its wings");
    }
  }
}