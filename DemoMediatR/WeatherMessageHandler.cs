using MediatR;

namespace DemoMediatR
{
    public class WeatherMessageHandler : IRequestHandler<WeatherMessage, WeatherForecast>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast> Handle(WeatherMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = request.Message + " || " +Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }
    }
}
