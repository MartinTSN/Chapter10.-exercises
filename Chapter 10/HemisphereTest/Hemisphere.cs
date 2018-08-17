using System;

class Hemisphere
{
    decimal radius = 1;

    public decimal Volume
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(4 / 3, (decimal)Math.PI), Radius);
        }
    }
    public decimal CurvedSurfaceArea
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(2, (decimal)Math.PI), Decimal.Multiply(Radius, 2));
        }
    }
    public decimal TotalSurfaceArea
    {
        get
        {
            return Decimal.Multiply(Decimal.Multiply(3, (decimal)Math.PI), Decimal.Multiply(Radius, 2));
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