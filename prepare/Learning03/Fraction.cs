using System;

public class Fraction
{
    private int _topnumber;
    private int _bottomnumber;

    public Fraction()
    {
        _topnumber = 1;
        _bottomnumber = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topnumber = wholeNumber;
        _bottomnumber = 1;
    }

    public Fraction(int topnumber, int bottomnumber)
    {
        _topnumber = topnumber;
        _bottomnumber = bottomnumber;
    }

    public string GetFractionString()
    {
        string fraction = $"{_topnumber}/{_bottomnumber}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double value = (double)_topnumber / (double)_bottomnumber;
        return value;
    }

}