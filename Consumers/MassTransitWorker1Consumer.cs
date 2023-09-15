using Microsoft.Extensions.Logging;

namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class MassTransitWorker1Consumer : IConsumer<MassTransitWorker1>
    {
        private readonly ILogger<MassTransitWorker1Consumer> _logger;

        public MassTransitWorker1Consumer(ILogger<MassTransitWorker1Consumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<MassTransitWorker1> context)
        {
            _logger.LogInformation("Received: {MessageValue}", context.Message.Value);
            return Task.CompletedTask;
        }
    }
}