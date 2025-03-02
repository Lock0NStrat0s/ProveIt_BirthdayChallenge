using System.Globalization;

namespace BirthdayChallenge;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter your birthdate (mm/dd/yyyy): ");
        //DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate);

        DateTime parsedDate = new DateTime(2020, 1, 1);
        DateTime currentDate = DateTime.Now;
        int daysElapsed = (currentDate - parsedDate).Days;

        Console.WriteLine($"Parsed: {parsedDate} Now: {currentDate}");
        Console.WriteLine($"Elapsed days: {daysElapsed}");
        Console.WriteLine($"You are {daysElapsed / 365} year(s), {(daysElapsed % 365) / 30} month(s), {(daysElapsed % 365 % 30) - 1} day(s).");

        // months until next birthday
        DateTime nextYearBirthDate = new DateTime(DateTime.Now.Year + 1, parsedDate.Month, parsedDate.Day);
        int daysUntilNextBDay = (nextYearBirthDate - currentDate).Days;
        Console.WriteLine($"Time until next birthday: {daysUntilNextBDay / 30} month(s), {(daysUntilNextBDay % 30) - 1} day(s).");

        // weekends until their birthday

    }
}
