﻿using MediatR;

namespace DemoMediatR
{
    public class WeatherMessage : IRequest<WeatherForecast>
    {
        public string Message { get; set; }
    }
}
