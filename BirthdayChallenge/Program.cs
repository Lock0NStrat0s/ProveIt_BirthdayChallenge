using System.Globalization;

namespace BirthdayChallenge;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter your birthdate (mm/dd/yyyy): ");
        //DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate);

        DateTime parsedDate = new DateTime(2011, 4, 23);

        int years = HowManyYearsOld(parsedDate);
        Console.WriteLine($"You are {years} years old,");

        int months = HowManyMonthsOld(parsedDate);
        Console.WriteLine($"Or, you are {months} months old,");

        int days = HowManyDaysOld(parsedDate);
        Console.WriteLine($"Or, you are {days} days old,");
        Console.WriteLine("--------------------------------------");

        int daysLeft = DaysUntilNextBirthday(parsedDate);
        Console.WriteLine($"There are {daysLeft} days left until your next birthday.");


    }

    private static int HowManyYearsOld(DateTime bday)
    {
        DateTime now = new DateTime(2019, 3, 11);
        int years = now.Year - bday.Year;

        if (now.Month < bday.Month)
        {
            years--;
        }
        else
        {
            if (now.Month == bday.Month && now.Day < bday.Day)
            {
                years--;
            }
        }

        return years;
    }

    private static int HowManyMonthsOld(DateTime bday)
    {
        DateTime now = new DateTime(2019, 3, 11);
        int years = HowManyYearsOld(bday);
        int months = years * 12;

        if (now.Month < bday.Month)
        {
            months += (now.Month + 12 - bday.Month);
        }
        else
        {
            months += (now.Month + 12);
        }

        return months;
    }

    private static int HowManyDaysOld(DateTime bday)
    {
        DateTime now = new DateTime(2019, 3, 11);

        int days = now.Subtract(bday).Days;

        return days;
    }

    private static int DaysUntilNextBirthday(DateTime bday)
    {
        DateTime now = new DateTime(2019, 3, 11);
        DateTime nextBday = GetNextBirthday(bday);

        int daysLeft = nextBday.Subtract(now).Days;

        return daysLeft;
    }

    private static int MonthsUntilNextBirthday(DateTime bday)
    {
        DateTime now = new DateTime(2019, 3, 11);
        DateTime nextBday = GetNextBirthday(bday);


    }

    private static int NumberOfWeekendsUntilNextBirthday(DateTime bday)
    {

    }

    private static DateTime GetNextBirthday(DateTime bday)
    {
        DateTime now = new DateTime(2019, 3, 11);
        DateTime nextBday = new DateTime(now.Year, bday.Month, bday.Day);

        if (now.Month >= bday.Month && now.Day >= bday.Day)
        {
            nextBday.AddYears(1);
        }

        return nextBday;
    }
}
