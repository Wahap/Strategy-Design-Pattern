using System;

namespace Strategy_Design_Pattern
{
  public interface ISwimBehaviour
  {
    void Swim();
  }

  public class NotSwim : ISwimBehaviour
  {
    public void Swim()
    {
      Console.WriteLine("it can not swim");
    }
  }

  public class CanSwim : ISwimBehaviour
  {
    public void Swim()
    {
      Console.WriteLine("it can swim.");
    }
  }
}