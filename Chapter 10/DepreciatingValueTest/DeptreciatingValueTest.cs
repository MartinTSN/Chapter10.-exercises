using System;

class DeptreciatingValueTest
{
    static void Main()
    {
        var asset1 = new DepreciatingValue(5000000);
        var asset2 = new DepreciatingValue(6000000);
        var asset3 = new DepreciatingValue(7000000);

        Console.WriteLine(asset1.ValueOfAsset);



        Console.ReadLine();
    }
}
