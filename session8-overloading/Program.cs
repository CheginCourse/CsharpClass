using System;

namespace session8over // Note: actual namespace depends on the project name.
{
    internal class Progam
    {
//  oop Design 
 static void Main(string[] args)
        {

  Add(3,6);
  Add(3.5 , 9.2);
  Add("asghar " , "akbari");


        }


        public static void Add(int x , int y){
          int result = x + y ;
         System.Console.WriteLine(result); 

        }
          public static void Add(Double x , Double y){
          
             Double result = x + y ;
            System.Console.WriteLine(result); 
        }
          public static void Add(string firstname , string lastname){
               string  result = $"{firstname}{lastname}" ;
         System.Console.WriteLine(result); 
          
        }
    }
}