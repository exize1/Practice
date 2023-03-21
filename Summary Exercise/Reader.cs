using System.Text;

namespace Summary_Exercise
{
    internal class Reader
    {
        public static string? BasePath;
        public static string? DirectoryName;
        public static string? FileName;
        public static string? FileType;
        public static string GetHighestAsciiName(Dictionary<string, string> someName)
        {
            var highestAsciiValue = 0;
            var highestAsciiKey = "";

            foreach (var name in someName)
            {
                var asciiValue = Encoding.ASCII.GetByteCount(name.Value);
                if (asciiValue <= highestAsciiValue) continue;
                highestAsciiValue = asciiValue;
                highestAsciiKey = name.Key;
            }

            return highestAsciiKey;
        }
        public static int GetHighestAsciiName(string name, int prevAsciiValue)
        {
            var asciiValue = Encoding.ASCII.GetByteCount(name);
            return asciiValue > prevAsciiValue ? asciiValue : prevAsciiValue;
        }

        public static void PrintHighestAsciiName()
        {
            if(string.IsNullOrWhiteSpace(BasePath)) return;

            var highestAsciiValue = 0;
            var highestAsciiKey = "";

            var directories = Directory.GetDirectories(BasePath);
            foreach (var path in directories)
            {
                if (!path.Contains($"{BasePath}\\{DirectoryName}")) continue;

                var fileInfo = File.ReadAllText($"{path}\\{FileName}.{FileType}");
                if(fileInfo == null) continue;

                var asciiValue = GetHighestAsciiName(fileInfo.ToString(), highestAsciiValue);
                if (asciiValue < highestAsciiValue) continue;

                highestAsciiValue = asciiValue;
                highestAsciiKey = path;
            }

            Console.WriteLine(highestAsciiKey);
        }
    }
}
