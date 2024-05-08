using System;
//THE FRACTION CLASS IS CREATED
public class Fraction
{
    // In this section we create the atributes, in this case, for the top and bottom numbers those are private
    private int _top;
    private int _bottom;

    // In this section we create the constructors
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        Console.WriteLine($"In this case we divide {_top} / {_bottom}");

        return (double)_top / (double)_bottom;
    }
}