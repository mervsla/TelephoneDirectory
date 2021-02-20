using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.ReportBusConfigurator;
using TelephoneDirectory.ReportService.PresentationLayer.Events;

namespace ReportConsumerConfig
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
