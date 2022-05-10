using System.Globalization;
namespace HarmonicSeries;

public static class HarmonicSeries
{
    public static string Sum(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException(nameof(number), "Number for the harmonic series sum must be at least 1");

        var result = 0.0d;
        for (int i = 1; i <= number; i++)
            result += 1.0d / (double)i;

        return result.ToString("F4", CultureInfo.InvariantCulture);
    }
}
