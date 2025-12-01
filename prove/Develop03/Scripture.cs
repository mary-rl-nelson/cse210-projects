using System;
using System.Collections.Generic;

public class Scripture
{
    private Refer _reference;
    private List<Word> _words;
    private Random _rand = new Random();

    public Scripture(Refer reference, string content)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = content.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            List<int> notHiddenWords = new List<int>();

            for (int index = 0; index < _words.Count; index++)
            {
                if (!_words[index].Hidden())
                {
                    notHiddenWords.Add(index);
                }
            }

            if (notHiddenWords.Count == 0)
            {
                return;
            }

            int randomIndex = _rand.Next(notHiddenWords.Count);
            int wordToHide = notHiddenWords[randomIndex];
            _words[wordToHide].Hide();
        }
    }

    public bool IsHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.Hidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplay()
    {
        string referenceText = _reference.GetReference();

        List<string> wordTexts = new List<string>();
        foreach (Word w in _words)
        {
            wordTexts.Add(w.GetDisplay());
        }

        string scriptureText = string.Join(" ", wordTexts);

        return referenceText + "\n" + scriptureText;
    }
}
