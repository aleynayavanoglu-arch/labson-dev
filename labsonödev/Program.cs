double[] week = { 14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4 };
static double Average(double[] t)
{
    double sum = 0;
    for (int i = 0; i < t.Length; i++)
    {
        sum += t[i];
    }
    return sum / t.Length;
}
double average = Average(week);
Console.WriteLine("Average: " + average.ToString("F1"));
int hottestIndex = 0;
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > week[hottestIndex])
    {
        hottestIndex = i;
    }
}
Console.WriteLine("Hottest day: Day " + (hottestIndex + 1));
Console.WriteLine("Temperature: " + week[hottestIndex]);
Console.WriteLine("Days above average:");
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > average)
    {
        Console.WriteLine("Day " + (i + 1) + ": " + week[i]);
    }
}
Console.WriteLine("Last three days:");
double[] lastThree = week[^3..];
foreach (double temperature in lastThree)
{
    Console.WriteLine(temperature);
}
double[] week = { 14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4 };
static double Average(double[] t)
{
    double sum = 0;
    for (int i = 0; i < t.Length; i++)
    {
        sum += t[i];
    }
    return sum / t.Length;
}
double average = Average(week);
Console.WriteLine("Average: " + average.ToString("F1"));
int hottestIndex = 0;
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > week[hottestIndex])
    {
        hottestIndex = i;
    }
}
Console.WriteLine("Hottest day: Day " + (hottestIndex + 1));
Console.WriteLine("Temperature: " + week[hottestIndex]);
Console.WriteLine("Days above average:");
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > average)
    {
        Console.WriteLine("Day " + (i + 1) + ": " + week[i]);
    }
}
Console.WriteLine("Last three days:");
double[] lastThree = week[^3..];
foreach (double temperature in lastThree)
{
    Console.WriteLine(temperature);
}
Console.WriteLine("Hello, World!");
