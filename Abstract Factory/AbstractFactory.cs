namespace DesignPatterns.Abstract_Factory;

public interface AbstractFactory
{
  public Transport? GetVehicle(string vehicleType);
}
