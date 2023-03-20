using System.Security.Cryptography;

namespace Summary_Exercise
{
    internal class Writer
    {
        private static DateTime _currentDateTime;
        public static string? BasePath;
        public static string? DirectoryName;


        /// <summary>
        /// Creates Directories according to the userInput
        /// </summary>
        /// <param name="userInput"></param>
        private static Dictionary<string, string> GenerateNamesToFile(int userInput, params string[] names)
        {
            _currentDateTime = DateTime.Now;
            var dictionary = new Dictionary<string, string>();

            for (int i = 0; i < userInput; i++)
            {
                string NewDirectoryPath = $"{BasePath}{DirectoryName}_{_currentDateTime:ddMMyy}_{i}";
                string randomName = names[RandomNumberGenerator.GetInt32(0, names.Length - 1)];

                Directory.CreateDirectory(NewDirectoryPath);
                File.WriteAllText($@"{NewDirectoryPath}\data.txt", randomName);

                dictionary.Add(NewDirectoryPath, randomName);
            }

            return dictionary;
        }

        private static bool IsValidInput(string input, out int folderCount)
        {
            folderCount = 0 ;
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"-X- {input}  **Invalid input: Can't be empty or white space!");
                return false;
            }

            bool validInput = int.TryParse(input, out int intInput);
            if (!validInput || intInput < 5 || intInput > 20)
            {
                Console.WriteLine($"Invalid input: {input}  **Input ust be a number between 5-20!");
                return false;
            }

            folderCount = intInput;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Dictionary<string, string> GenerateNamesToFiles(params string[] names)
        {
            bool validInput;
            var dictionary = new Dictionary<string, string>();
            do
            {
                Console.WriteLine();
                Console.Write("Please enter a number between 5 to 20: ");
                var input = Console.ReadLine();

                validInput = IsValidInput(input, out int foldersCount);

                if (validInput)
                {
                    dictionary = GenerateNamesToFile(foldersCount, names);
                }
            } while (!validInput);

            return dictionary;
        }
    }
}
