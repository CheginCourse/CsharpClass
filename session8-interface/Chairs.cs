using System;

namespace session8In // Note: actual namespace depends on the project name.
{

  public class Chairs : Furniture ,IDestroyable

  {
     public string Sound { get; set; }
public Chairs(string color , string material) : base(color,material)
{
  
Sound = "diiiinnnnnngggg";


}

  

    public void Fire()
    {
      System.Console.WriteLine($"the sound is {Sound}");
    }
  }
}