public static string GetPrettyDate(DateTime date)
{
    return date.ToString("dddd, dd MMMM yyyy HH:mm:ss");
}

// Usage
Console.WriteLine(GetPrettyDate(DateTime.Now.AddHours(-4)));
