using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
        //   // Stack
        //         Stack<string> stack1 = new Stack<string>();
        //         stack1.Push("asdas");
        //         stack1.Push("ddd");
        //         stack1.Push("aaa");
        //         stack1.Push("gggg");
                
        //        System.Console.WriteLine(stack1.Peek()); 
        //         foreach (var item in stack1)
        //         {
        //             System.Console.WriteLine(item);
        //         }

        // Queue

        Queue<string> queue1 = new Queue<string>();
        queue1.Enqueue("1");
         queue1.Enqueue("2");
          queue1.Enqueue("3");
           queue1.Enqueue("4");
        foreach (var item in queue1)
        {
            System.Console.WriteLine(item);
        }
                
                

        }
    }
}