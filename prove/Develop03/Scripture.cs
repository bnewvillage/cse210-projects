using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetReference();
        _words = new List<Word>();
        foreach (var wordString in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(wordString));
        }
    }
    //end of constructor

public void HideRandomWords(int numberOfWords)
{
    int hiddenWords = 0;
    Random random = new Random();

    while (hiddenWords < numberOfWords)
    {
        int randomIndex = random.Next(_words.Count);
        Word randomWord = _words[randomIndex];

        if (randomWord.GetStatus() == false)
        {
            string selectedWord = randomWord.GetWord();
            
            selectedWord = new string('_', selectedWord.Length);
            randomWord.SetWord(selectedWord);
            randomWord.Hide();
            hiddenWords++;
        }

        int availableWords = _words.Count(word => word.GetStatus() == false);
        if (availableWords < numberOfWords - hiddenWords)
        {
            break;
        }
    }
}




    //Returning the Full Scripture Verse
    public string GetScripture()
    {
        List<string> wordStrings = new List<string>();
        foreach (var word in _words)
        {
            wordStrings.Add(word.GetWord());
        }
        return _reference + " " + string.Join(" ", wordStrings);
    }
    //end of returning full scripture verse
}
