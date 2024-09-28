using System;
using System.Globalization;

class CinderellaClock
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        string[] input = Console.ReadLine().Split(' ');

        double A = double.Parse(input[0]);
        double B = double.Parse(input[1]);

        double hours = A / 30;
        double minutes = B / 6;

        double remainingHours = 12 - hours;
        double remainingMinutes = 60 - minutes;

        double remainingSeconds = remainingHours * 3600;
        if (remainingMinutes != 60)
        {
            remainingSeconds += remainingMinutes * 60;
        }
        Console.WriteLine((int)remainingSeconds);
    }
}