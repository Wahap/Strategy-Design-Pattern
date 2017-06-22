namespace Strategy_Design_Pattern.BO
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

}
