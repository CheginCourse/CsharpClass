using System;

namespace session8In // Note: actual namespace depends on the project name.
{
    internal class Progam
    {
//  oop Design 
 static void Main(string[] args)
        {

        Cars objCar = new Cars(3.5,"Blue");
        Chairs objChair = new Chairs("Red","Iron");

        objCar.Fire();
        objChair.Fire();

        }
    }
}


        