namespace DesignPatterns.Observer;

public class Store : IStore
{
    private List<ICustomer> customers = new List<ICustomer>();
    private string latestProduct;

    public void Attach(ICustomer customer)
    {
        customers.Add(customer);
    }

    public void Detach(ICustomer customer)
    {
        customers.Remove(customer);
    }

    public void Notify()
    {
        foreach (var customer in customers)
        {
            customer.Update(this); // 'this' = store
        }
    }

    public void AddNewProduct(string product)
    {
        latestProduct = product;
        Notify(); // add more criteria  for notifying,
    }

    public string GetLatestProduct()
    {
        return latestProduct;
    }
}
