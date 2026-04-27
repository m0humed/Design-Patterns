using Adapter.Legacy;
using Adapter.Project.Entities;

namespace Adapter.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var legacyForecasts = CreateLegacyForecasts();

            Console.WriteLine("Legacy -> Adapter scenario");
            Console.WriteLine();

            foreach (var legacy in legacyForecasts)
            {
                var adapted = new WeatherForcastAdabter(legacy);

                Console.WriteLine(
                    $"Date: {adapted.Date:yyyy-MM-dd} | " +
                    $"C: {adapted.TemperatureC} | " +
                    $"F: {adapted.TemperatureF} | " +
                    $"UnderZero: {adapted.UnderZero} | " +
                    $"Summary: {adapted.Summary}");
            }
        }

        private static IReadOnlyList<WeatherForecast> CreateLegacyForecasts()
        {
            string[] summaries =
            [
                "Freezing",
                "Bracing",
                "Chilly",
                "Cool",
                "Mild",
                "Warm",
                "Balmy",
                "Hot",
                "Sweltering",
                "Scorching",
            ];

            return Enumerable.Range(1, 5)
                .Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = summaries[Random.Shared.Next(summaries.Length)],
                })
                .ToArray();
        }
    }
}
