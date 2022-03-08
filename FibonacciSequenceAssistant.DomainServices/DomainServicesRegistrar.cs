using FibonacciSequenceAssistant.DomainServices.Commands.ContinueFibonacciSequence;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FibonacciSequenceAssistant.DomainServices
{
    public static class DomainServicesRegistrar
    {
        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            services.AddMediatR(typeof(ContinueFibonacciSequenceCommandHandler));
        }
    }
}