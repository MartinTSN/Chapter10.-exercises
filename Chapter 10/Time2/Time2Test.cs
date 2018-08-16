﻿using System;

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

        Console.ReadLine();
    }
}