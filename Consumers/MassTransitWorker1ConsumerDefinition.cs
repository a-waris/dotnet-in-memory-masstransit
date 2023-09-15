namespace Company.Consumers
{
    using MassTransit;

    public class MassTransitWorker1ConsumerDefinition :
        ConsumerDefinition<MassTransitWorker1Consumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<MassTransitWorker1Consumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}