using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

      class ActionWithFunction
      {
        public void ActionFunction (int x , int y , int z){
          System.Console.WriteLine($"{x} {y} {z}");
        }
        public bool FucMethod(int x){
           System.Console.WriteLine($"{x} ");
           return true;
        }

      }

      class Person 
      {
        public delegate void  testDelgate();
        public testDelgate testDelegateFunction;

        public void DelegateFunction(){
          System.Console.WriteLine("Del function1");
        }

         public void DelegateFunction2(){
          System.Console.WriteLine("Del function2");
        }

      }
        static void Main(string[] args)
        {
          Person objPerson = new Person();
            objPerson.testDelegateFunction = objPerson.DelegateFunction;
            objPerson.testDelegateFunction += objPerson.DelegateFunction2;
            objPerson.testDelegateFunction();
            // you can iterate Delegates 
              var lstDel =      objPerson.testDelegateFunction.GetInvocationList();
               foreach (var item in lstDel)
               {
               System.Console.WriteLine(item.Method);
              }
            // Action 
            ActionWithFunction objActionWithFunction = new ActionWithFunction();
            Action<int,int,int> objAction =objActionWithFunction.ActionFunction;
            objAction(3,4,6);
            //Func
            Func<int,bool> FuncTest = objActionWithFunction.FucMethod;
        var result =    FuncTest(5);

         System.Console.WriteLine(result);




        }
    }
}
