using System;

public class Entry
{
    // 属性はアンダースコアから始まる _camelCase (Style基準)
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; 

    public Entry(string date, string prompt, string entry, string mood)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
        _mood = mood;
    }

    // 各エントリーを表示する責務
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}/5");
        Console.WriteLine($"{_entryText}\n");
    }
}