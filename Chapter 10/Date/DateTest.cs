using System;

class DateTest
{
    static void Main()
    {
        var date1 = new Date(11, 24, 1949);
        var date2 = new Date(3, 12, 1988);

        for (int i = 0; i < 410; i++)
        {
            Console.WriteLine(date1.NextDay());
        }


        Console.ReadLine();
    }
}
