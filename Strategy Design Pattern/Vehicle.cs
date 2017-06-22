namespace Strategy_Design_Pattern
{
  public abstract class Vehicle
  {
    public IFlyBehaviour FlyBehaviour;
    public ISwimBehaviour SwimBehaviour;

    public string Name { get; set; }
    public string Weight { get; set; }


    public void PerformFly()
    {
      FlyBehaviour.Fly();
    }

    public void PerfomSwim()
    {
      SwimBehaviour.Swim();
    }

  }


  public class Bus : Vehicle
  {
    public Bus()
    {
      FlyBehaviour = new NotFly();
      SwimBehaviour = new NotSwim();
    }

  }

  public class Ship : Vehicle
  {
    public Ship()
    {
      FlyBehaviour = new FlyWithWings();
      SwimBehaviour = new CanSwim();
    }
  }

}
