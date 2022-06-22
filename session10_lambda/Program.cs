// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Dogs
    {
        public string Name { get; set; }    
         public int Number { get; set; }

         public bool IsHappy { get; set; }   




    }
    class Movies
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //lambda expersions
            List<int> lstNumbers = new List<int>{1,2,4,6,8,9,11,1,1};
            System.Console.WriteLine("Max of lstNumber");
           System.Console.WriteLine(lstNumbers.Max());
            System.Console.WriteLine("Min of lstNumber"); 
           System.Console.WriteLine(lstNumbers.Min());
                 System.Console.WriteLine("remove duplicates"); 
           lstNumbers.Distinct().ToList().ForEach(c=>System.Console.WriteLine(c));
            List<int> lstNumbers2 = new List<int>{1,2,4,1,8,34,11};
            int lstAdd =    lstNumbers2.Aggregate((x,y)=>x+y );   
            //( x = [value of last lambda expression], y = [next value] ) => x+y
            System.Console.WriteLine(lstAdd);
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

                    // Determine whether any string in the array is longer than "banana".
                string longestName =
                        fruits.Aggregate("banana",
                        (longest, next) =>
                        next.Length > longest.Length ? next : longest,
                        // Return the final result as an upper case string.
                        fruit => fruit.ToUpper());
               
                    Console.WriteLine(
                    "The fruit with the longest name is {0}.",
                    longestName);
                List<string> lstNames =new List<string>{"akbar","asghar","reza","batol","abas"};
                 List<string> lstStudents =new List<string>{"asghar","reza","batol","abas","karim","ghazanfar"};
                 // result is false
                 System.Console.WriteLine(lstNames.Contains("ghazanfar"));
                lstNames.Add("ghazanfar");
                // result is True 
                System.Console.WriteLine(lstNames.Contains("ghazanfar"));
                lstNames.Except(lstStudents);
                // result is true
                lstNames.Any(c=>c.EndsWith('r'));
                    // result is False
                    lstNames.All(c=>c.EndsWith('r'));
                    // remove items which start with a
                lstNames.RemoveAll(c=>c.StartsWith("a"));
                foreach (var item in lstNames)
                {
                    System.Console.WriteLine(item);
                }
               // C# chunk (only in .Net core 6 and 7)
           var FirstList=  lstNames.Chunk(3).ElementAt(0).ToList();
           foreach (var item in FirstList)
           {
            System.Console.WriteLine(item);
           }
            //List for Dogs
            List<Dogs> lstDogs = new List<Dogs>{
                new Dogs{ Name="bunny" ,Number=1 , IsHappy=true },
                new Dogs{ Name="misha" ,Number=10 , IsHappy=true },
                new Dogs{ Name="pisha" ,Number=13 , IsHappy=false },
                new Dogs{ Name="Max" ,Number=18 , IsHappy=true },
                new Dogs{ Name="rocky" ,Number=91 , IsHappy=true },
                new Dogs{ Name="kachal" ,Number=31 , IsHappy=false },
                new Dogs{ Name="padari" ,Number=28 , IsHappy=true },
                new Dogs{ Name="whiny" ,Number=26 , IsHappy=true }

            };  
            lstDogs.Where(c=>c.Number > 20).ToList().ForEach(c=>System.Console.WriteLine(c.Name));
            lstDogs.Select(c=>c.Number).ToList().ForEach(c=>System.Console.WriteLine(c));
            lstDogs.FindAll(c=>c.Name.StartsWith('m')).ToList().ForEach(c=>System.Console.WriteLine(c.Name));
           System.Console.WriteLine(lstDogs.MaxBy(c=>c.Number).Number);
       // join 

        
            List<Movies> listOne = new List<Movies>()
            {
                new Movies(){ ID=1,Name= "HarryPotter"},
                new Movies(){ ID=2,Name= "PirateofCarrabian"},
            };

            List<Movies> listTwo = new List<Movies>()
            {
                new Movies(){ ID=1, Name=" and the Philosopher's Stone"},
                new Movies(){ ID=1, Name=" and the Chamber of Secrets"},
                new Movies(){ ID=1, Name=" and the Prisoner of Azkaban"},
                new Movies(){ ID=1, Name=" and the Goblet of Fire"},
                new Movies(){ ID=1, Name=" and the Order of the Phoenix"},
                new Movies(){ ID=1, Name=" and the Half-Blood Prince"},
                new Movies(){ ID=1, Name=" and the Deathly Hallows"},
                new Movies(){ ID=2, Name="  1"},
                new Movies(){ ID=2, Name="  2"},
                new Movies(){ ID=2, Name="  3"},
                new Movies(){ ID=2, Name=" : On Stranger Tides"},
            };

          listOne.Join(// outer sequence 
                      listTwo,  // inner sequence 
                      movie => movie.ID,    // outerKeySelector
                      movie2 => movie2.ID,  // innerKeySelector
                      (movie, movie2) => new  // result selector
                      {
                    
                          StandardName = movie.Name + movie2.Name
                      }).ToList().ForEach(c=>System.Console.WriteLine(c.StandardName));         

            // innerJoin.ToList().ForEach(p => Console.WriteLine(p.StandardName, "Name"));






        
        }
    }
}