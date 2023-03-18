using System.Security.Cryptography;

namespace Summary_Exercise
{
    internal class Writer
    {
        private static DateTime _currentDateTime;
        readonly static string _basePath = @"C:\Users\amio1\OneDrive\שולחן העבודה\Amit";

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
                string NewDirectoryPath = $"{_basePath}_{_currentDateTime:ddMMyy}_{i}";
                string randomName = names[RandomNumberGenerator.GetInt32(0, names.Length - 1)];

                Directory.CreateDirectory(NewDirectoryPath);
                File.WriteAllText($@"{NewDirectoryPath}\data.txt", randomName);

                dictionary.Add(randomName, NewDirectoryPath);
            }

            return dictionary;
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

                validInput = int.TryParse(input, out int foldersCount);

                if (validInput)
                {
                    dictionary = GenerateNamesToFile(foldersCount, names);
                }
                else
                {
                    Console.WriteLine($"-X- {validInput}  **Invalid input please try again!");
                }
            } while (!validInput);

            return dictionary;
        }
    }
}
