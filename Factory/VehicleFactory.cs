
namespace DesignPatterns.Factory;

public class VehicleFactory
{
  public Transport? getVehicle(string vehicleType)
  {
    if (vehicleType == "Ship")
    {
      return new Ship();
    }
    else if (vehicleType == "Truck")
    {
      return new Truck();
    }

    return null;
  }
}
