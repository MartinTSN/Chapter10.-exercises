using System;

class Time2Test
{
    static void Main()
    {
        var t1 = new Time2();
        var t2 = new Time2(2);
        var t3 = new Time2(21, 34);
        var t4 = new Time2(12, 25, 42);
        var t5 = new Time2(t4);

        Console.WriteLine("Constructed with:\n");
        Console.WriteLine("t1: all arguments defaulted");
        Console.WriteLine($"{t1.ToUniversalString()}");
        Console.WriteLine($"{t1.ToString()}\n");

        Console.WriteLine("t2: hour specified; minute and second defaulted");
        Console.WriteLine($"{t2.ToUniversalString()}");
        Console.WriteLine($"{t2.ToString()}\n");

        Console.WriteLine("t3: hour and minute specified; second defaulted");
        Console.WriteLine($"{t3.ToUniversalString()}");
        Console.WriteLine($"{t3.ToString()}\n");

        Console.WriteLine("t4: hour, minute and second defaulted");
        Console.WriteLine($"{t4.ToUniversalString()}");
        Console.WriteLine($"{t4.ToString()}\n");

        Console.WriteLine("t5: Time2 object t4 specified");
        Console.WriteLine($"{t5.ToUniversalString()}");
        Console.WriteLine($"{t5.ToString()}");


        try
        {
            var t6 = new Time2(27, 74, 99);
        }
        catch (ArgumentOutOfRangeException ex)
        {

            Console.WriteLine("\nException while initializing t6:");
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nTime set with seconds");
        Console.WriteLine("Constructed with:\n");
        Console.WriteLine("t1: all arguments defaulted");
        t1.ToHoursMinutesSeconds(t1.ToSeconds(t1.Hour, t1.Minute, t1.Second));
        Console.WriteLine($"{t1.ToUniversalString()}");
        Console.WriteLine($"{t1.ToString()}\n");

        Console.WriteLine("t2: hour specified; minute and second defaulted");
        t2.ToHoursMinutesSeconds(t2.ToSeconds(t2.Hour, t2.Minute, t2.Second));
        Console.WriteLine($"{t2.ToUniversalString()}");
        Console.WriteLine($"{t2.ToString()}\n");

        Console.WriteLine("t3: hour and minute specified; second defaulted");
        t3.ToHoursMinutesSeconds(t3.ToSeconds(t3.Hour, t3.Minute, t3.Second));
        Console.WriteLine($"{t3.ToUniversalString()}");
        Console.WriteLine($"{t3.ToString()}\n");

        Console.WriteLine("t4: hour, minute and second defaulted");
        t4.ToHoursMinutesSeconds(t4.ToSeconds(t4.Hour, t4.Minute, t4.Second));
        Console.WriteLine($"{t4.ToUniversalString()}");
        Console.WriteLine($"{t4.ToString()}\n");

        Console.WriteLine("t5: Time2 object t4 specified");
        t5.ToHoursMinutesSeconds(t5.ToSeconds(t5.Hour, t5.Minute, t5.Second));
        Console.WriteLine($"{t5.ToUniversalString()}");
        Console.WriteLine($"{t5.ToString()}");


        try
        {
            var t6 = new Time2(27, 74, 99);
        }
        catch (ArgumentOutOfRangeException ex)
        {

            Console.WriteLine("\nException while initializing t6:");
            Console.WriteLine(ex.Message);
        }


        Console.ReadLine();
    }
}