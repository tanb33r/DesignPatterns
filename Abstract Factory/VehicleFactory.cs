
namespace DesignPatterns.Abstract_Factory;

  public class VehicleFactory : AbstractFactory
  {
      public Transport? GetVehicle(string vehicleType)
      {
          if(vehicleType == null)
          {
              return null;
          }
          else if(vehicleType == "Truck")
          {
              return new Truck();
          }
          else if(vehicleType == "Ship")
          {
              return new Ship();
          }

          return null;
      }
  }
