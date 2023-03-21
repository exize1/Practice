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
        Writer.BasePath = Reader.BasePath = @"C:\Users\amio1\OneDrive\שולחן העבודה\ForExercise";
        Writer.DirectoryName = Reader.DirectoryName = "Amit";
        Writer.FileName = Reader.FileName =  "Data";
        Writer.FileType = Reader.FileType = "txt";
        
        Writer.GenerateNamesToFiles(_ourDepartmentNames);
        
        Reader.PrintHighestAsciiName();

    }
}
