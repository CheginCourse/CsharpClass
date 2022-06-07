namespace session8Struct // Note: actual namespace depends on the project name.
{


   public struct Rectangle
  {
    public int X { get; set; }
    public int Y { get; set; }

    public Rectangle(int x , int y )
    {
      this.X = x;
      this.Y = y;
    }

    public void TotalArea(){
      int Area = X * Y;
      System.Console.WriteLine(Area);
    }

  }
    internal class Progam
    {
//  oop Design 
 static void Main(string[] args)
        {

          //Structure
          Rectangle StrRec = new Rectangle(10,2);
          StrRec.TotalArea();



        }

    }
}