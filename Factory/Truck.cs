﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory;

public class Truck : Transport
{
  public void Deliver()
  {
    Console.WriteLine("Delivered By Truck");
  }
}
