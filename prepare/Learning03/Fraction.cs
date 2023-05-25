

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        // Return string rep. of fraction
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Convert from int to double and perform calc
        double decimalValue = (double)_top / _bottom;
        // Round answer to 2d.p
        decimalValue = Math.Round(decimalValue, 2);
        // Return value
        return decimalValue;
    }
}