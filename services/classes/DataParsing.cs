using DataGuard.services.interfaces;
using System;
using System.Linq;
namespace DataGuard.services.classes;
class DataParsing : IParser
{
    public List<Dictionary<string, string>> DictionaryParser(string[] lines)
    {
        List < Dictionary < string, string>> listFromParsing = new List < Dictionary <string, string> >();
        string[] firstLine = lines[0].Split(",");
        foreach (string line in lines.Skip(1))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            string[] strings = line.Split(",");
            int lineLength = strings.Length;
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < lineLength; i++)
                dict.Add(firstLine[i], strings[i]);
            listFromParsing.Add(dict);
        }
        return listFromParsing;
    }
}