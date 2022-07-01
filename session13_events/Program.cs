using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  class EventClass
  {
     public event EventHandler onSpaceTrigger;
     public void TestingSpaceTrigger ( Object sender , EventArgs e ){
      System.Console.WriteLine("U key with event");
     }
     public void Test(){
      var name = System.Console.ReadKey();
      System.Console.WriteLine();
      if (name.Key == ConsoleKey.U)
      {
   
        onSpaceTrigger?.Invoke(this,EventArgs.Empty);
      }

     }

  }
    internal class Program
    {
        static void Main(string[] args)
        {
            EventClass objEventClass = new EventClass();
            objEventClass.onSpaceTrigger +=objEventClass.TestingSpaceTrigger;
            objEventClass.Test();
        }
    }
}
