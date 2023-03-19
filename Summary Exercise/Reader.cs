using System.Text;

namespace Summary_Exercise
{
    internal class Reader
    {
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

        public static void OpenDirectories()
        {
            var directories = Directory.GetDirectories(@"C:\Users\amite\Desktop");
            Console.WriteLine(directories[0]);
        }
    }
}
