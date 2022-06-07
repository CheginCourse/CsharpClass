using System;

namespace session8In  // Note: actual namespace depends on the project name.
{

  public class Cars : Vehicle,IDestroyable

  {
public string Sound { get; set; }
    public Cars(double speed , string color) : base(speed,color)
    {
      
Sound = "boooooooooomm";

    }

    

    public void Fire()
    {
     System.Console.WriteLine($"the sound is {Sound}");
    }
  }
}