
namespace DesignPatterns.Abstract_Factory;

public class AbFactory
{
  public void ShowTransport()
  {
    AbstractFactory factory = FactoryProducer.GetFactory(industrial: false);
    AbstractFactory industrialFactory = FactoryProducer.GetFactory(industrial: true);

    Transport? truck = factory.GetVehicle("Truck");
    truck?.Deliver();

    Transport? ship = factory.GetVehicle("Ship");
    ship?.Deliver();

    Transport? industrialTruck = industrialFactory.GetVehicle("Truck");
    industrialTruck?.Deliver();

    Transport? industrialShip = industrialFactory.GetVehicle("Ship");
    industrialShip?.Deliver();
  }
}
