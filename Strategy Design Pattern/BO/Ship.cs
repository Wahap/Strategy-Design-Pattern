namespace Strategy_Design_Pattern.BO
{
  public class Ship : Vehicle
  {
    public Ship()
    {
      FlyBehaviour = new FlyWithWings();
      SwimBehaviour = new CanSwim();
    }
  }
}
