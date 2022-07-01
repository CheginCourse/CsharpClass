using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

     partial class Merged
      {
        public int Age { get; set; }
        public String Name { get; set; }
        
      }
       partial class Merged
      {
        
        public void SetName(int age , string name){

          this.Age = age;
          this.Name = name;
          System.Console.WriteLine($"{Age} {Name}");

        }
      }

        static void Main(string[] args)
        {

            Merged objMerged = new Merged();
     
            objMerged.SetName(23 , "akbar");

        }
    }
}
