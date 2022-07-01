using System;

namespace MyApp // Note: actual namespace depends on the project name.
{



  class GarbageTest
  {
    public GarbageTest()
    {
      
    }
    //Destructors
    // Finalizer
~GarbageTest()
{

System.Console.WriteLine("Destroy by Finalizer");
}

  }
    internal class Program
    {
      public static void CheckGarbageCollection(){
        GarbageTest objGarbageTest = new GarbageTest();
      }
        static void Main(string[] args)
        {
           CheckGarbageCollection();
           GC.Collect();
           GC.WaitForPendingFinalizers();

        }
    }
}
