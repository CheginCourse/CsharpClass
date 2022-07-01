using System;
using System.IO;  

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          FileStream fs = new FileStream(@"/Users/abtin_cheg/Desktop/CsharpMainClass/CsharpClass/session9_streams/test.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
          fs.Seek(0,SeekOrigin.End);
          ///----------------- Stream Writer -----------------///
          StreamWriter objStreamWriter = new StreamWriter(fs);
          objStreamWriter.WriteLine("hello");
          objStreamWriter.AutoFlush = true;
          ///-----------------Stream Reader ------------------///
          using(StreamReader reader = new StreamReader(@"/Users/abtin_cheg/Desktop/CsharpMainClass/CsharpClass/session9_streams/test.txt")) {
    string line;
    while((line = reader.ReadLine()) != null) {
      System.Console.WriteLine("Enter");
  string result=  reader.ReadToEnd();
         System.Console.WriteLine(result);
  
    }
}
        
       

           
        }
    }
}
