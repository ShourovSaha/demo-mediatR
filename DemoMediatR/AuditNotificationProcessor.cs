using MediatR;

namespace DemoMediatR
{
    public class AuditNotificationProcessor : INotificationHandler<Audit>
    {
        public Task Handle(Audit notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Audit notification processing... || " + notification.Message);
            return Task.CompletedTask;
        }
    }
}
