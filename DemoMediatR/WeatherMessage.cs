using MediatR;

namespace DemoMediatR
{
    public class WeatherMessage : IRequest<WeatherForecast>
    {
    }
}
