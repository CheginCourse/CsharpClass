// See https://aka.ms/new-console-template for more information
using System;

namespace session5 // Note: actual namespace depends on the project name.
{
    internal class Progam
    {
        static void Main(string[] args)
        {
          //Array and List 

          string[] strStudents  =  new string[6];

          System.Console.WriteLine("Enter student name ? ");


          for (int i = 0; i < strStudents.Length; i++)
          {
            strStudents[i]= Console.ReadLine();
          }

            Array.Sort(strStudents);

          System.Console.WriteLine("Class member of DotNetA ");
          //foreach loop for Array and List
          foreach (string item in strStudents)
          {
            
           System.Console.WriteLine(item);   
              

          }
          // List 

          List<string> lstStudents = new List<string>();
          System.Console.WriteLine("Enter student name ? ");
           for (int i = 0; i < 6; i++)
          {
            lstStudents.Add(Console.ReadLine());
          }
          lstStudents.Sort();
          System.Console.WriteLine("Class member of DotNetA ");
          foreach (var item in lstStudents)
          {
             System.Console.WriteLine(item); 

          }
        }
    }
}