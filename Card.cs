using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

public class Card
{
    private string _question;  // encapsulation, variables are private and may only be accessed through getters/setters
    private string _answer;
    private string _note;

    public string Question
    {
        get { return _question; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Question cannot be empty.");
            _question = value;
        }
    }

    public string Answer
    {
        get { return _answer; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Answer cannot be empty.");
            _answer = value;
        }
    }

    public string Note
    {
        get { return _note; }
        set
        {
            _note = string.IsNullOrWhiteSpace(value) ? "" : value;
        }
    }

    // polymorphism through method overload
    public Card(string question, string answer)
    {
        Question = question;
        Answer = answer;
        _note = null;
    }

    // card with note
    public Card(string question, string answer, string note)
    {
        Question = question;
        Answer = answer;
        Note = note;
    }

    public Card()
    {
        _question = "";
        _answer = "";
        _note = "";
    }

    public bool HasNote()
    {
        return !string.IsNullOrWhiteSpace(_note);
    }
}

