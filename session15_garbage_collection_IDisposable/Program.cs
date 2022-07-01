using System;

namespace MyApp // Note: actual namespace depends on the project name.
{



  class GarbageTest : IDisposable
  {
    public GarbageTest() 
    {
      
    }
    public void Dispose(){
      System.Console.WriteLine("Disposed");

    }

  }
    internal class Program
    {
      public static void CheckGarbageCollection(){
        using ( GarbageTest objGarbageTest = new GarbageTest())
        {
          
        }
       
      }
        static void Main(string[] args)
        {
           CheckGarbageCollection();
            GarbageTest objGarbageTest = new GarbageTest();
            objGarbageTest.Dispose();

        }
    }
}
