namespace DesignPatterns.Abstract_Factory;

public class Truck : Transport
{
  public void Deliver()
  {
    Console.WriteLine("Delivered by Truck");
  }
}
