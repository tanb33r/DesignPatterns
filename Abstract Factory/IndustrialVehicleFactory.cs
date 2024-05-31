namespace DesignPatterns.Abstract_Factory;

public class IndustrialVehicleFactory : AbstractFactory
{
  public Transport? GetVehicle(string vehicleType)
  {
    if (vehicleType == "Truck")
    {
      return new IndustrialTruck();
    }
    else if (vehicleType == "Ship")
    {
      return new IndustrialShip();
    }

    return null;
  }
}
