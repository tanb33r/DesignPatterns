namespace DesignPatterns.Observer;

public class Customer : ICustomer
{
  private string customerName;

  public Customer(string name)
  {
    customerName = name;
  }

  public void Update(IStore store)
  {
    Store concreteStore = (Store)store;
    string latestProduct = concreteStore.GetLatestProduct();

    Console.WriteLine($"Customer {customerName} received update: New product - {latestProduct}");
  }
}
