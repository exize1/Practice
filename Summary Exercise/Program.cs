using System;

namespace Summary_Exercise;

internal class Program
{
    static void Main(string[] args)
    {
        string[] _ourDepartmentNames = new string[20]
            {
                "Amit", "Nitzan", "Mor", "Roi.Y",
                "Yaniv", "Peter", "Asher", "Itzik",
                "Michael", "Roi.A", "Meir", "Arteum", "Evgeny",
                "David", "Bar", "Vadim", "Roi.P", "Carolina", "Nerihya",
                "Dor"
            };
        Writer.BasePath =  @"C:\Users\amite\Desktop\";
        Writer.DirectoryName = "Amit";
        var result = Writer.GenerateNamesToFiles(_ourDepartmentNames);

        Reader.BasePath = @"C:\Users\amite\Desktop\";
        Reader.DirectoryName = "Amit";
        //Reader.PrintHighestAsciiName();
        var highestAsciiValue  = Reader.GetHighestAsciiName(result);

        Console.WriteLine(highestAsciiValue);

    }
}
