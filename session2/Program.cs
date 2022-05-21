using System;

namespace session2
{
    class Program
    {
        static void Main(string[] args)
        {

//variables

        // int unary = 0;
        // int preIncrement;
        // int preDecrement;
        // int postIncrement;
        // int postDecrement;
        // int positive;
        // int negative;
        // sbyte bitNot;
        // bool logNot;

        // preIncrement = ++unary;
        // Console.WriteLine("pre-Increment: {0}", preIncrement);

        // preDecrement = --unary;
        // Console.WriteLine("pre-Decrement: {0}", preDecrement);

        // postDecrement = unary--;
        // Console.WriteLine("Post-Decrement: {0}", postDecrement);

        // postIncrement = unary++;
        // Console.WriteLine("Post-Increment: {0}", postIncrement);

        // Console.WriteLine("Final Value of Unary: {0}", unary);


        // logNot = false;
        // logNot = !logNot;
        // Console.WriteLine("Logical Not: {0}", logNot);



       //operators 
        // int x, y, result;
        // float floatresult;

        // x = 7;
        // y = 5;

        // result = x+y;
        // Console.WriteLine("x+y: {0}", result);

        // result = x-y;
        // Console.WriteLine("x-y: {0}", result);

        // result = x*y;
        // Console.WriteLine("x*y: {0}", result);

        // result = x/y;
        // Console.WriteLine("x/y: {0}", result);

        // floatresult = (float)x/(float)y;
        // Console.WriteLine("x/y: {0}", floatresult);

        // result = x%y;
        // Console.WriteLine("x%y: {0}", result);

        // result += x;
        // Console.WriteLine("result+=x: {0}", result);

        // If and Else 

        // if (true)
        // {
            
        // }
        // else {


        // }


            // Tamrin 1 
            // System.Console.WriteLine("Enter your name :");
            // string Name = Console.ReadLine();
            // System.Console.WriteLine("Enter your Age");
            // int Age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"my name is {Name} and Iam {Age} years old");
            // Tamrin 2 
             string IsShab = DateTime.Now.ToString().Substring(19,2); // Az character 19 2 ta joda mikonim
             System.Console.WriteLine("Enter your Number ? ");
             sbyte Num = Convert.ToSByte(Console.ReadLine());
             if (Num % 2 == 0)
             {
                 System.Console.WriteLine("even number");
             }
            else
            {
             System.Console.WriteLine("odd number");   
            }
             if (Num > 5)
             {
                 System.Console.WriteLine("greater than 5"); 
             }
            else
            {
               System.Console.WriteLine("Less than 5");  
            }
            if (IsShab=="PM")
            {
               System.Console.WriteLine("GoodNight");  
            }
            else
            {
                System.Console.WriteLine("Good day"); 
            }
            
        }
    }
}
