

namespace DesignPatterns.Factory;

public class Factory
{
  public void ShowTransport()
  {
    VehicleFactory vehicleFactory = new();
    Transport? truck = vehicleFactory.getVehicle("Truck");
    Transport? ship = vehicleFactory.getVehicle("Ship");

    truck?.Deliver();
    ship?.Deliver();
    //Sub classes decides the operation
  }
}
