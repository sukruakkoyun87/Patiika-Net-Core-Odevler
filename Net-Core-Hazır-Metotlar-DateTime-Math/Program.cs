// See https://aka.ms/new-console-template for more information

Console.WriteLine(DateTime.Now);    // Prints the current date and time to the console
Console.WriteLine(DateTime.Now.Date);   // Date only
Console.WriteLine(DateTime.Now.Day);    // Day of the month
Console.WriteLine(DateTime.Now.Month);  // 1-12
Console.WriteLine(DateTime.Now.Year);   // 2020
Console.WriteLine(DateTime.Now.Hour);   // 0-23
Console.WriteLine(DateTime.Now.Minute);     // 0-59
Console.WriteLine(DateTime.Now.Second);     // 0-59

Console.WriteLine(DateTime.Now.DayOfWeek);  // Sunday = 0, Monday = 1, ...
Console.WriteLine(DateTime.Now.DayOfYear);  // 1-365


Console.WriteLine(DateTime.Now.ToLongDateString()); // Thursday, November 20, 2019
Console.WriteLine(DateTime.Now.ToShortDateString());    // yyyy-MM-dd

Console.WriteLine(DateTime.Now.ToLongTimeString()); // HH:MM:SS
Console.WriteLine(DateTime.Now.ToShortTimeString());    // 12:00:00 AM

Console.WriteLine("*************************");

Console.WriteLine(DateTime.Now.AddDays(2)); // 2 days
Console.WriteLine(DateTime.Now.AddHours(3));    // 3 hours
Console.WriteLine(DateTime.Now.AddSeconds(20));     // 20 seconds
Console.WriteLine(DateTime.Now.AddMonths(5));   // 5 months
Console.WriteLine(DateTime.Now.AddYears(10));   // 10 years
Console.WriteLine(DateTime.Now.AddMilliseconds(50));    // 50 milliseconds

// DateTime Format
Console.WriteLine("*************************");

Console.WriteLine(DateTime.Now.ToString("dd")); // Day
Console.WriteLine(DateTime.Now.ToString("ddd"));    // short
Console.WriteLine(DateTime.Now.ToString("dddd"));   // full name of day


Console.WriteLine(DateTime.Now.ToString("MM"));     // 01, 02, 03, ..., 12
Console.WriteLine(DateTime.Now.ToString("MMM"));    // Jan
Console.WriteLine(DateTime.Now.ToString("MMMM"));   // Month

Console.WriteLine(DateTime.Now.ToString("yy")); // 2 digit year
Console.WriteLine(DateTime.Now.ToString("yyyy"));   // yyyy = 4 digit year


// Math Kütüphanesi
Console.WriteLine("*************************");

Console.WriteLine(Math.Abs(-25)); //25
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); //23
Console.WriteLine(Math.Round(22.3)); //22
Console.WriteLine(Math.Round(22.7)); //23
Console.WriteLine(Math.Floor(22.7)); //23

Console.WriteLine(Math.Min(2, 6));  // 2
Console.WriteLine(Math.Max(2, 6));  // 6
Console.WriteLine(Math.Pow(3, 4)); //3^4 verir 81
Console.WriteLine(Math.Sqrt(9)); //9 karekökü verir 3
Console.WriteLine(Math.Log(9)); //9 logaritması verir 2.0794415416798357
Console.WriteLine(Math.Exp(3)); //3.718281828459045 verir 20.085536923187668
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritme 10 tabanındaki karşılığını değeri verir.





