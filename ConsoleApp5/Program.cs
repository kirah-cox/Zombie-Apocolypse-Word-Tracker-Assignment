using Journal;
using System.Text.Json;
class Program
{
    static void Main()
    {
        string path = "C:/Users/kirah.cox/source/repos/ConsoleApp5/ConsoleApp5/Data.json";
        string text = File.ReadAllText(path);

        ZombieSurvivalJournal manual = JsonSerializer.Deserialize<ZombieSurvivalJournal>(text);

        Dictionary<string, int> keyWords = new Dictionary<string, int>();

        List<string> unecessaryWords = new List<string>
        {
            "the", "and", "is", "a", "for", "i", "of", "in", "on", "with", "as", "by", "at", "from", "was", "no", "are", "into", "an", "we", "to", "but", "must"
        };

        foreach (var item in manual.Entries)
        {
            var words = item.Text.Split(" ");

            foreach (var word in words)
            {

                string fixedWord = word.Replace(",", "").Replace(".", "").Replace("!", "").ToLower().Trim();

                if (!keyWords.ContainsKey(fixedWord) && !unecessaryWords.Contains(fixedWord))
                {
                    keyWords.Add(fixedWord, 1);
                }
                else if (!unecessaryWords.Contains(fixedWord))
                {
                    keyWords[fixedWord]++;
                }
            }
        }

        var topWords = keyWords.OrderByDescending(word => word.Value).Take(5);

        foreach (var word in topWords)
        {
            Console.WriteLine(word.Key + ": " + word.Value);
        }
    }
}