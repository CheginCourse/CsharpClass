using System;

namespace session3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /// IF can be Useful but .. 
            // var say_my_name = Console.ReadLine();
            //  System.Console.WriteLine("Say my name? ");

            // if (say_my_name.ToLower() == "abas")
            // {
            //     Console.WriteLine("Baleee !");
            // }
            // else if (say_my_name == "akbar")
            // {
            //     Console.WriteLine("akbar dadashame ..");
            // }
            // else
            // {
            //     Console.WriteLine($"inja ma {say_my_name.ToString()} nadarim ");
            // }
            

            // switch case 
        //     var say_my_name = Console.ReadLine().ToString().ToLower();
        //    switch (say_my_name)
        //    {
        //        case "abas":
        //             Console.WriteLine("Baleee !");
        //            break;
        //            case "akbar":
        //             Console.WriteLine("akbar dadashame ..");
        //            break;
        //        default:
        //             Console.WriteLine($"inja ma {say_my_name.ToString()} nadarim ");
        //            break;
        //    }
           // Loop 
        // 4 type of Loop

        // for (var i = 0; i < length; i++)
        // {
            
        // }
           
            //do
        //{
              
            //} while (true);
            // while (true)
            // {
                
            // }

            //Tamrin 1 
            // for (var i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine("Enter your command:");
            //     if (Console.ReadLine().ToLower()=="c")

            //     {
            //     Console.WriteLine("game is over ");
            //     break;

            //     }
            // }
            //Tamrin 2 
            //   System.Console.WriteLine("Enter your command:");
            //   while (Console.ReadLine().ToLower()!="c")
            //   {
            //      System.Console.WriteLine("Enter your command:"); 
            //   }
            //   System.Console.WriteLine("Game is over ");

            //Tamrin 3
            // string Input ="";
            // System.Console.WriteLine("Enter your command:");
            // do
            // {
            //  System.Console.WriteLine("enter your command");   
            //  Input = Console.ReadLine().ToLower();
            // } while (Input!="c");
           // Tamrin 4 
           Console.WriteLine(GetFullName("abtin","chegini"));
            


             

        }

        public static string GetFullName(string FirstName , string LastName){
        // you can swap your variable :)

            (FirstName,LastName)= (LastName,FirstName);
            string FullName = $"{FirstName} {LastName}";
            return FullName;
        }
    }
}
