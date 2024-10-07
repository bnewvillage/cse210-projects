using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
    }
    
    public void Hide(){
        _isHidden = true;
    }

    public void Show(){
        _isHidden = false;
    }

    public string GetWord(){
        return _text;
    }

    public void SetWord(string newtext){
        _text = newtext;
    }

    public bool GetStatus(){
        return _isHidden;
    }

}