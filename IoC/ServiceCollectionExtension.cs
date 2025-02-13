using System;
using System.Collections.Generic;
using System.Text;
using BookDepo.ApiClient.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BookDepo.ApiClient.IoC
{
    public static class ServiceCollectionExtension
    {
        public static void AddBookApiClientService(this IServiceCollection services,
                                                Action<ApiClientOptions> options) {
            services.Configure(options);
            services.AddSingleton(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ApiClientOptions>>().Value;
                return new BookDepoApiClientService(options);
            });
        }
    }
}
