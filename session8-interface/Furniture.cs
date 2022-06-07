 
 
 using System;

namespace session8In // Note: actual namespace depends on the project name.
{
 public class Furniture

  {

   public string Color { get; set; }
   public string Material { get; set; }

public Furniture(string  color ,string material )
{
  this.Color = color;
  this.Material = material;
}
public Furniture()
{
  Color = "Red";
  Material = "Wooden";

}


  }

}