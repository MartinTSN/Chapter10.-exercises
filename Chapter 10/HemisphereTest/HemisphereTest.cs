using System;

class HemisphereTest
{
    static void Main()
    {
        Hemisphere hemisphere = new Hemisphere();
        Console.Write("How big is the radious of the Hemisphere?\n");
        hemisphere.Radius = Decimal.Parse(Console.ReadLine());

        Console.WriteLine($"\nThe Volume of the Hemisphere is: {hemisphere.Volume}Cm^3");
        Console.WriteLine($"\nThe Curved Surface Area of the Hemisphere is: {hemisphere.CurvedSurfaceArea}Cm^2");
        Console.WriteLine($"\nThe Total Surface Area of the Hemisphere is: {hemisphere.TotalSurfaceArea}Cm^2");

        Console.ReadLine();
    }
}

