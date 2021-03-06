﻿class DepreciatingValue
{
    private static decimal annualDepreciationRate;
    private decimal valueOfAsset;

    public DepreciatingValue(decimal valueOfAsset = 0, decimal annualDepreciationRate = 10)
    {
        ValueOfAsset = valueOfAsset;
        AnnualDepreciationRate = annualDepreciationRate;
    }


    public static decimal AnnualDepreciationRate
    {
        get
        {
            return annualDepreciationRate;
        }
        set
        {
            annualDepreciationRate = value;
        }
    }

    public decimal ValueOfAsset
    {
        get
        {
            return valueOfAsset;
        }
        set
        {
            valueOfAsset = value;
        }
    }

    public decimal CalculateAnnualDepreciation(decimal valueOfAsset)
    {
        ValueOfAsset = valueOfAsset / AnnualDepreciationRate;
        return ValueOfAsset;
    }
}