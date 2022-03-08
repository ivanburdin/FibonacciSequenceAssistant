using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor
{
    public static class FibonacciSequenceAuthorRegistrar
    {
        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            var rabbitOptions =
                configuration.GetSection(nameof(RabbitOptions)).Get<RabbitOptions>();

            services.AddSingleton(rabbitOptions);

            services.AddSingleton<IFibonacciSequenceAuthorClient, FibonacciSequenceAuthorClient>();
        }
    }
}