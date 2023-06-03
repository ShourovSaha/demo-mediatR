using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoMediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<WeatherForecast?> Get()
        {
            var response = await _mediator.Send(new WeatherMessage { Message = "Weather test message" });
            await _mediator.Publish(new Audit { Message = "Weather message sent for audit." });
            return response;
        }
    }
}