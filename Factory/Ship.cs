using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory;

public class Ship : Transport
{
  public void Deliver()
  {
    Console.WriteLine("Delivered By Ship");
  }
}