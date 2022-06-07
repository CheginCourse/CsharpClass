
using System;

namespace session8In // Note: actual namespace depends on the project name.
{
 public class Vehicle

  {

public double Speed { get; set; }
public string Color { get; set; }

public Vehicle()
{
  
Speed =4.9;
Color ="Blue";

}
public Vehicle(double speed , string color)
{
  
  this.Color = color;
  this.Speed = speed;
}


  }
}