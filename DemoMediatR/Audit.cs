using MediatR;

namespace DemoMediatR
{
    public class Audit : INotification
    {
        public string Message { get; set; }
    }
}
