using MediatR;

namespace DemoMediatR
{
    public class AuditNotificationHandler : INotificationHandler<Audit>
    {
        public Task Handle(Audit notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.Message);
            return Task.CompletedTask;
        }
    }
}
