using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

    public string GetFractionString ()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

    //wanted to try my own stretch challenge

    private double _decimal;
    private double Get_Decimal()
    {
        return _decimal = (double)_top/(double)_bottom;
    }
    public void MakeAFraction() 
    {
        Console.Write("Top Nuber: ");
        _top = int.Parse(Console.ReadLine());
        Console.Write("Bottom Number: ");
        _bottom = int.Parse(Console.ReadLine());

        Get_Decimal();


        Console.WriteLine($"As a Fraction: {_top}/{_bottom}");
        Console.WriteLine($"As a decimal: {_decimal}");


    }
}