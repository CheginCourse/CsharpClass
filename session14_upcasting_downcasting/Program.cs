using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        class Shape
        {
            
            public int X { get; set; }
            public int Y { get; set; }
        }
        class Circle : Shape
        {
            public void GetName(){
                System.Console.WriteLine(" NAme");
            }
        }
        static void Main(string[] args)
        {
                Circle objCir =  new Circle();
                Shape objShape = objCir;
                objShape.X = 200;
                objCir.X=300;
                System.Console.WriteLine(objShape.X);

                Circle cir2 = (Circle)objShape;
                cir2.X =700;
                objShape.X = 900;
                System.Console.WriteLine(cir2.X);

            // Console.WriteLine("Hello World!");
        }
    }
}
