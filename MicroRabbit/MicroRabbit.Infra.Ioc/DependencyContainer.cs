using MicroRabbit.Domain.Core.Bus;
using MicroService.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain bus

            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
