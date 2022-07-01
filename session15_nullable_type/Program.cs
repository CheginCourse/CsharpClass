using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime objDateTime= new DateTime();
            // Nullable<DateTime> objNullableDatetime= new   Nullable<DateTime>();
            // you can use DateTime? instead of Nullable<DateTime>
            // Nullable<DateTime> ----> DateTime?
            // this always true 
             DateTime?  objNullableDatetime = objDateTime;
             // but this one is not (Cannot implicitly convert type 'System.DateTime?' to 'System.DateTime')
            //  DateTime objNewDatetime= objNullableDatetime;

            System.Console.WriteLine(objNullableDatetime.GetValueOrDefault());
            System.Console.WriteLine(objNullableDatetime.Value);

        }
    }
}
