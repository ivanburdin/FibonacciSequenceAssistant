using FibonacciSequenceAssistant.DomainServices;
using FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FibonacciSequenceAssistant.Presentation
{
    public class Startup
    {
        public readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            DomainServicesRegistrar.Configure(Configuration, services);
            FibonacciSequenceAuthorRegistrar.Configure(Configuration, services);

            services.AddControllers();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseEndpoints(
                endpoints => { endpoints.MapControllers(); }
            );
        }
    }
}