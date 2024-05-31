namespace DesignPatterns.Observer;

public interface IStore
{
  void Attach(ICustomer customer);
  void Detach(ICustomer customer);
  void Notify();
}
