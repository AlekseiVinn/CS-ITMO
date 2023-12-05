using System;

internal class Distance 
{
    protected int _feet;
    protected double _inches;

    public Distance() { }

    public Distance(double inches)
    {
        _feet = (int)(inches / 12);
        _inches = inches % 12;
    }
    
    public Distance(int feet, double inches)
    {
        _feet = feet + (int)(inches / 12);
        _inches = inches % 12;
    }

    public int Feet 
    {
        get { return _feet; }
    }

    public double Inches
    {
        get { return _inches; }
    }

    public static Distance operator +(Distance a, Distance b)
    {
        int feet = a.Feet + b.Feet + (int)((a.Inches + b.Inches) / 12);
        double inches = (a.Inches + b.Inches) % 12;
        return new Distance(feet, inches);
    }

    public static Distance operator -(Distance a, Distance b)
    {
        double inches = (a.Feet*12 + a.Inches) - (b.Feet*12 + b.Inches);
        if (inches >= 0)
        {
            int feet = (int)inches / 12;
            inches %= 12;
            return new Distance(feet, inches);
        }
        else
        {
            int feet = (int)inches / 12;
            if (feet == 0)
            {
                return new Distance(feet, inches);
            }
            else
            {
                inches -= 12*feet;
                
                return new Distance(feet, inches);
            }
        }
    }

    public static bool operator >(Distance a, Distance b)
    {
        return _ = ((a.Feet * 12 + a.Inches) > (b.Feet * 12 + b.Inches));
    }

    public static bool operator <(Distance a, Distance b)
    {
        return _ = ((a.Feet * 12 + a.Inches) < (b.Feet * 12 + b.Inches));
    }

    public static bool operator ==(Distance a, Distance b)
    {
        return _ = ((a.Feet * 12 + a.Inches) == (b.Feet * 12 + b.Inches));
    }

    public static bool operator !=(Distance a, Distance b)
    {
        return _ = ((a.Feet * 12 + a.Inches) != (b.Feet * 12 + b.Inches));
    }

    public static bool operator >=(Distance a, Distance b)
    {
        return _ = ((a.Feet * 12 + a.Inches) >= (b.Feet * 12 + b.Inches));
    }

    public static bool operator <=(Distance a, Distance b)
    {
        return _ = ((a.Feet * 12 + a.Inches) <= (b.Feet * 12 + b.Inches));
    }

    public override bool Equals(object o)
    {
        Distance dist = o as Distance;
        if (dist != null)
        {
           return _ = (this == dist);
     
        }
        else { return false; }
    }

    public override string ToString()
    {
        if (Inches >= 0)
        {
            return $"{Feet}'-{Inches}\"";
        }
        else
        {
            return _ = Feet == 0? $"—{Feet}'-{-Inches}\"" : $"{Feet}'-{-Inches}\"";
        }
    }

    /**static Distance CreateDistance(string info)
    {
        if (int.TryParse(info, out int inches))
        {
            return new Distance(inches);
        }
        else
        {
            throw new InvalidOperationException("No element satisfies the given condition.");
        }
    }**/

}

