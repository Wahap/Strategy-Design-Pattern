namespace Strategy_Design_Pattern.BO
{
  public class Bus : Vehicle
  {
    public Bus()
    {
      FlyBehaviour = new NotFly();
      SwimBehaviour = new NotSwim();
    }
    

  }
}
