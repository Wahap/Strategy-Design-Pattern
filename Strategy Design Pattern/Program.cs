using System;
using Strategy_Design_Pattern.BO;

namespace Strategy_Design_Pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Vehicle bus= new Bus();
      Console.WriteLine(bus.GetType().Name);
      bus.PerfomSwim();
      bus.PerformFly();

       

      Vehicle ship= new Ship();
      Console.WriteLine(ship.GetType().Name);
      ship.PerfomSwim();
      ship.PerformFly();

    }
  }
}
 