using System;

namespace Strategy_Design_Pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Vehicle bus= new Bus();
      Console.WriteLine(bus.GetType());
      bus.PerfomSwim();
      bus.PerformFly();

       

      Vehicle ship= new Ship();
      Console.WriteLine(ship.GetType());
      ship.PerfomSwim();
      ship.PerformFly();

    }
  }
}
 