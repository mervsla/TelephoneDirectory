using MassTransit;
using System;
using System.Threading.Tasks;
using TelephoneDirectory.ReportBusConfigurator;
using TelephoneDirectory.ReportService.PresentationLayer.Events;

namespace ReportConsumerConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var bus = BusConfigurator.ConfigureBus(factory =>
            {
                factory.ReceiveEndpoint(RabbitMqConstants.ConsumerQueue, endpoint =>
                {
                    endpoint.Consumer<ReportConsumer>();
                });
            });

            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}
