using System;

public class Hemisphere
{
    decimal radius = 1;

    public Hemisphere(decimal radius = 1)
    {

    }

    public decimal Volume
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(2 / (decimal)3, (decimal)Math.PI), Radius);
        }
    }
    public decimal CurvedSurfaceArea
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(2, (decimal)Math.PI), Radius);
        }
    }
    public decimal TotalSurfaceArea
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(3, (decimal)Math.PI), Radius);
        }
    }

    public decimal Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (value > 0.0m && value < 12.0m)
            {
                radius = value;
            }
        }
    }
}