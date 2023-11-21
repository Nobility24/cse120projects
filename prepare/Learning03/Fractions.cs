using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topValue)
    {
        _top = topValue;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

     public string GetFractionString()
    {
        //This is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

     public double GetDecimalValue()
    {
        //This is also not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}
