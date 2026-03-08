using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // CSV形式: 各項目を引用符で囲み、カンマが含まれても読み込めるように工夫
                outputFile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\",\"{entry._mood}\"");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: The file was not found.");
            return;
        }

        _entries.Clear(); // 既存のリストを置き換える (要件)
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // 引用符付きカンマで分割
            string[] parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
            if (parts.Length == 4)
            {
                string date = parts[0].Trim('"');
                string prompt = parts[1].Trim('"');
                string entry = parts[2].Trim('"');
                string mood = parts[3].Trim('"');
                _entries.Add(new Entry(date, prompt, entry, mood));
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}   