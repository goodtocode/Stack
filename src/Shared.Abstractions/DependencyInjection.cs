﻿//using Microsoft.Extensions.DependencyInjection;

//namespace GoodToCode.Infrastructure.SqlServer
//{
//    public static class DependencyInjection
//    {
//        public static IServiceCollection AddInfrastructureAzure(this IServiceCollection services)
//        {
//            services.AddSingleton<IAzureEventPublisher, AzureEventPublisher>();
//            services.AddSingleton<IBus, Bus>();
//            services.AddSingleton<IEventDispatcher, EventDispatcher>();
//            services.AddSingleton<IMessageBus, MessageBus>();
//            return services;
//        }
//    }
//}