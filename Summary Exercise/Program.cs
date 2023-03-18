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

        var folderPathWritenName = Writer.GenerateNamesToFiles(_ourDepartmentNames);
        var name = Reader.GetHighestASCIIName(_ourDepartmentNames);

        Console.WriteLine($"{folderPathWritenName.TryGetValue(name, out string path)} {name} ");


    }
}
