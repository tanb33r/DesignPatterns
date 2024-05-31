namespace DesignPatterns;


//sealed = not inheritable, making sure single instance of the class
sealed class SingletonService
{
  private SingletonService() { }
  public int Id { get; private set; }

  private static SingletonService _instance;
  private static readonly object _lock = new();
  public static SingletonService Instance(int id)
  {
    if (_instance == null)
    {
      lock (_lock) // make it thread safe
      {
        if (_instance == null)
        {
          _instance = new SingletonService();
          _instance.Id = id;
        }
      }
    }

    return _instance;
  }
}
