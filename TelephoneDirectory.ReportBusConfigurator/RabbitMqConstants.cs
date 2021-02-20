using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.ReportBusConfigurator
{
   public class RabbitMqConstants
    {

        public const string RabbitMqUri = "rabbitmq://localhost/";
        public const string Username = "guest";
        public const string Password = "guest";
        public const string ConsumerQueue = "receiver";
    }
}
