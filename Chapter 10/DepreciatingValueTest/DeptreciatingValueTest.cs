using System;

class DeptreciatingValueTest
{
    static void Main()
    {
        var asset1 = new DepreciatingValue(5000000);
        var asset2 = new DepreciatingValue(6000000);
        var asset3 = new DepreciatingValue(7000000);

        Console.WriteLine("Innitial value");
        Console.WriteLine($"Value of asset1: {asset1.ValueOfAsset:C}");
        Console.WriteLine($"Value of asset2: {asset2.ValueOfAsset:C}");
        Console.WriteLine($"Value of asset3: {asset3.ValueOfAsset:C}");

        Console.WriteLine("\nAfter 1 calculation (after 1 year)");
        Console.WriteLine($"Value of asset1: {asset1.CalculateAnnualDepreciation(asset1.ValueOfAsset):C}");
        Console.WriteLine($"Value of asset2: {asset2.CalculateAnnualDepreciation(asset2.ValueOfAsset):C}");
        Console.WriteLine($"Value of asset3: {asset3.CalculateAnnualDepreciation(asset3.ValueOfAsset):C}");

        DepreciatingValue.AnnualDepreciationRate = 11;
        for (int i = 0; i < 3; i++)
        {
            asset1.CalculateAnnualDepreciation(asset1.ValueOfAsset);
            asset2.CalculateAnnualDepreciation(asset2.ValueOfAsset);
            asset3.CalculateAnnualDepreciation(asset3.ValueOfAsset);
        }
        Console.WriteLine("\nAfter 3 calculations (3 years)");
        Console.WriteLine($"Value of asset1: {asset1.ValueOfAsset:C}");
        Console.WriteLine($"Value of asset2: {asset2.ValueOfAsset:C}");
        Console.WriteLine($"Value of asset3: {asset3.ValueOfAsset:C}");

        Console.ReadLine();
    }
}
