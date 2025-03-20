using Journal;
using System.Text.Json;
class Program
{
    static void Main()
    {
        string path = "C:\\Users\\kirah.cox\\source\\repos\\ConsoleApp5\\ConsoleApp5\\Data.json";
        string text = File.ReadAllText(path);

        ZombieSurvivalJournal manual = JsonSerializer.Deserialize<ZombieSurvivalJournal>(text);

        Dictionary<string, int> keyWords = new Dictionary<string, int>();

        foreach (var item in manual.Entries)
        {
            var words = item.Text.Split(" ");

            foreach (var word in words)
            {

                string fixedWord = word.Replace(',', ' ').Replace('.', ' ').ToLower().Trim();

                if (!keyWords.ContainsKey(fixedWord))
                {
                    keyWords.Add(fixedWord, 1);
                }
                else
                {
                    keyWords[fixedWord]++;
                }
            }
        }

        foreach (var word in keyWords)
        {
            Console.WriteLine(word.Key + " " + word.Value);
        }
    }
}