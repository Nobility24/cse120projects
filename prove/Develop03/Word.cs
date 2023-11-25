using System;
using System.Collections.Generic;
using System.IO;

// Class to represent a word in the scripture
class ScriptureWord
{
    public string Word { get; private set; }
    public bool IsHidden { get; set; }

    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "______" : Word;
    }
}