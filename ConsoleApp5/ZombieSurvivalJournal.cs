using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Journal
{
    public class ZombieSurvivalJournal
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("entries")]
        public List<Entry> Entries { get; set; }
    }

    public class Entry
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
