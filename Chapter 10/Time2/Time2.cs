using System;

public class Time2
{
    private int hour;
    private int minute;
    private int second;

    public Time2(int hour = 0, int minute = 0, int second = 0)
    {
        SetTime(hour, minute, second);
        ToSeconds(Hour, Minute, Second);
    }

    public Time2(Time2 time)
        : this(time.hour, time.minute, time.second)
    {
    }

    public void SetTime(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;

    }

    public int Hour
    {
        get
        {
            return hour;
        }
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hour)} must be 0-23");
            }
            hour = value;
        }
    }

    public int Minute
    {
        get
        {
            return minute;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Minute)} must be above 0");
            }
            minute = value;
        }
    }

    public int Second
    {
        get
        {
            return second;
        }
        set
        {
            if (value < 0 || value > 86399)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Second)} must be above 0 - 86399");
            }
            second = value;
        }
    }

    public int ToSeconds(int hour, int minute, int second)
    {
        minute = hour * 60 + minute;
        Second = minute * 60 + second;
        Hour = 0;
        Minute = 0;
        return Second;
    }

    public Time2 ToHoursMinutesSeconds(int second)
    {
        Hour = second / 60 / 60;
        second = second - (Hour * 60 * 60);

        Minute = second / 60;
        second = second - (Minute * 60);

        Second = second;
        Time2 time2 = new Time2(Hour, Minute, Second);
        return time2;
    }
    public string ToUniversalString()
    {
        ToHoursMinutesSeconds(Second);
        return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
    }

    public override string ToString()
    {
        return $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
                $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
    }
}