using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  class  Ticket : IEquatable<Ticket>
  {
    public int DurationHours { get; set; }
    public string Name { get; set; }


    public Ticket(int durationhours, string name )
    {
      this.DurationHours = durationhours;
      this.Name = name;

    }
      // only compare durationHours
    public bool Equals(Ticket other)
    {
      return other.DurationHours == this.DurationHours;
    }
    //  compare both cases
    // public bool Equals(Ticket other)
    // {
    //   return (other.DurationHours == this.DurationHours && other.Name == this.Name) ? true : false ;
    // }
    // only compare Names
    // public bool Equals(Ticket other)
    // {
    //   return other.Name == this.Name;
    // }
  }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket objTicket1 = new Ticket(22,"abtinCheg");
             Ticket objTicket2 = new Ticket(12,"abtinCheg");
              System.Console.WriteLine((objTicket1.Equals(objTicket2) ? "True" : "False") );

        }
    }
}
