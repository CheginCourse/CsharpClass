using System;
using Newtonsoft.Json;
namespace MyApp // Note: actual namespace depends on the project name.
{

    // you can add newtonsoft with this command in vs code 
    // dotnet add package Newtonsoft.Json



public static class Dumper
{
    public static string ToPrettyString(this object value)
    {
         return JsonConvert.SerializeObject(value, Formatting.Indented);
    }

    public static T Dump<T>(this T value)
    {
        Console.WriteLine(value.ToPrettyString());
        return value;
    }
}

    internal class Program
    {
        static async Task Main(string[] args)
    {
  await MakeTea(); 

    }

    public static async Task< string> MakeTea()
    {
     var waterFunc = boilingWater();
     "livano dar miarim ".Dump();
     "tea bag o   mindazim to livan".Dump();
      var water = await waterFunc;

     var tea = $"{water} o be chai ezafe mikonim";
     return tea;




    }

 public static async Task< string> boilingWater()
    {
     "ketri roshan kon".Dump();
    //  "baraue ketri missstimmmmmmmmm !".Dump();
    await Task.Delay(3000);
     return "water";



    }

  }
}
