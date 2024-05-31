namespace DesignPatterns.Observer;

public class ShowObserverPattern
{
  public ShowObserverPattern()
  {
    Store store = new Store();

    Customer customer1 = new Customer("Tanvir");
    Customer customer2 = new Customer("Taher");
    Customer customer3 = new Customer("Zahid"); // didnt get attached

    store.Attach(customer1);
    store.Attach(customer2);

    store.AddNewProduct("Smartphone"); // Notifies all customers

    store.Detach(customer1); // Unsubscribe one customer

    store.AddNewProduct("Laptop"); // Only customer2 will receive the update

  }
}
