using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using TelephoneDirectory.ReportBusConfigurator.Models;

namespace TelephoneDirectory.UI.Hubs
{
    public class UIHub:Hub
    {
        public async Task SendMessageAsync(Report report)
        {
            //await Clients.All.SendAsync("", report);
        }
    }
}
