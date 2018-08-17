using System;

public class Hemisphere
{
    decimal radius;

    public Hemisphere(decimal radius = 1)
    {

    }

    public decimal Volume
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(2 / 3, (decimal)Math.PI), Radius);
            //Decimal.Divide(Decimal.Multiply(Decimal.Multiply(2 / 3, (decimal)Math.PI), Decimal.Multiply(Radius, 3)), 2);
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
            if (value > 0.0m || value < 12.0m)
            {
                radius = value;
            }
        }
    }
}