using DesignPatterns;
using DesignPatterns.Factory;
using DesignPatterns.Abstract_Factory;
using DesignPatterns.Facade;
using DesignPatterns.Observer;
using DesignPatterns.Command;

Thread firstThread = new(() =>
{
  var instance = SingletonService.Instance(1);
});

Thread secondThread = new(() =>
{
  var instance = SingletonService.Instance(2);
});

firstThread.Start();
secondThread.Start();

firstThread.Join();
secondThread.Join();


//Factory Design pattern test
Factory factory = new();
factory.ShowTransport();

Console.WriteLine("\n/***************************/\n");

//Abstract Factory Design Pattern Test
AbFactory abFactory = new();
abFactory.ShowTransport();
Console.WriteLine("\n/***************************/\n");

// Facade hides all the complicated business logics and provides a simple interface
VideoUploadSystem videoUploadSystem = new ();
Console.WriteLine();

// These 2 were missing

ShowObserverPattern ShowObserverPattern = new ShowObserverPattern();
Console.WriteLine();


ShowCommandPattern ShowCommandPattern = new ShowCommandPattern();
Console.WriteLine();