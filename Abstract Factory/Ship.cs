
namespace DesignPatterns.Abstract_Factory;

public class Ship : Transport
{
  public void Deliver()
  {
    Console.WriteLine("Delivered by Ship");
  }
}
