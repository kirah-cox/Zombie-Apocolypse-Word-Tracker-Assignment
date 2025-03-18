using Journal;
using System.Text.Json;
class Program
{
    static void Main()
    {
        string path = "C:\\Users\\kirah.cox\\source\\repos\\ConsoleApp5\\ConsoleApp5\\Data.json";
        string text = File.ReadAllText(path);

        var manual = JsonSerializer.Deserialize<ZombieSurvivalJournal>(text);
    }
}