namespace DesignPatterns.Abstract_Factory;

public class FactoryProducer
{
  public static AbstractFactory GetFactory(bool industrial)
  {
    if (industrial)
    {
      return new IndustrialVehicleFactory();
    }
    else
    {
      return new VehicleFactory();
    }
  }
}
