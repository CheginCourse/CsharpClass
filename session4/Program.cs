using System;

namespace session4 // Note: actual namespace depends on the project name.
{
    internal class Progam
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your Number ? ");  
            short input = Convert.ToInt16( Console.ReadLine());
            //Enums 
            switch (input)
            {
              
              case 1: 
              System.Console.WriteLine($"your planet is {Planets.Mercury} ");
              break;
              case 2: 
              System.Console.WriteLine($"your planet is {Planets.Venus} ");
              break;
              case 3: 
              System.Console.WriteLine($"your planet is {Planets.Earth} ");
              break;
              case 4: 
              System.Console.WriteLine($"your planet is {Planets.Mars} ");
              break;
              case 5: 
              System.Console.WriteLine($"your planet is {Planets.Jupiter} ");
              break;
              case 6: 
              System.Console.WriteLine($"your planet is {Planets.Saturn} ");
              break;
              case 7: 
              System.Console.WriteLine($"your planet is {Planets.Uranus} ");
              break;
              case 8: 
              System.Console.WriteLine($"your planet is {Planets.Neptune} ");
              break;
              case 9: 
              System.Console.WriteLine($"your planet is {Planets.Pluto} ");
              break;

              default:
              System.Console.WriteLine("your planet not found");
              break;
            }

// inline conditioning

// int age= 21;
// string advice = (age < 21) ? "too young" : "you are not getting old ";
// System.Console.WriteLine(advice);


        }

public enum Planets
{
  
  Mercury = 1 ,
  Venus = 2 ,
  Earth = 3 ,
  Mars = 4 ,
  Jupiter = 5 ,
  Saturn = 6 , 

  Uranus = 7 ,
  Neptune = 8 ,

  Pluto = 9 








}

    }
}