using System;

namespace MyApp // Note: actual namespace depends on the project name.
{


  class Dogs
    {
        public string Name { get; set; }    
         public int Number { get; set; }

         public bool IsHappy { get; set; }   




    }
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] scores = { 97, 92, 81, 60 };

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
System.Console.WriteLine("Numbers");
foreach (int i in scoreQuery)
{
    Console.WriteLine(i + " ");
}
  List<Dogs> lstDogs = new List<Dogs>{
                new Dogs{ Name="bunny" ,Number=1 , IsHappy=true },
                new Dogs{ Name="misha" ,Number=10 , IsHappy=true },
                new Dogs{ Name="pisha" ,Number=13 , IsHappy=false },
                new Dogs{ Name="Max" ,Number=18 , IsHappy=true },
                new Dogs{ Name="procky" ,Number=91 , IsHappy=true },
                new Dogs{ Name="kachal" ,Number=31 , IsHappy=false },
                new Dogs{ Name="padari" ,Number=28 , IsHappy=true },
                new Dogs{ Name="whiny" ,Number=26 , IsHappy=true }

            };  

System.Console.WriteLine("Dogs start with p");
IEnumerable<string> DogsStartWithM =
    from dogs in lstDogs
    where dogs.Name.StartsWith('p') 
    select dogs.Name;
foreach (var item in DogsStartWithM)
{
    System.Console.WriteLine(item);
}
           
        }



    }
}
