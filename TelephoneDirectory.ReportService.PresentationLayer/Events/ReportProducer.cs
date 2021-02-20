using MassTransit;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.ReportBusConfigurator.Models;

namespace TelephoneDirectory.ReportService.PresentationLayer.Events
{
    public class ReportProducer : IConsumer<IReportProducer>
    {
        public async Task Consume(ConsumeContext<IReportProducer> context)
        {
            
            HubConnection connection = new HubConnectionBuilder().WithUrl("https://localhost:44320/UIHub").Build();
            await connection.StartAsync();

            await connection.InvokeAsync("SendMessageAsync", context.Message);

            await connection.StopAsync();
        }
    }
}
