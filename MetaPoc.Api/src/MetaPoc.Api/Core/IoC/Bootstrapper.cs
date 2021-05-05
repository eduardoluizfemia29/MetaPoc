using MediatR;
using MetaPoc.Api.Core.Swagger;
using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using MetaPoc.Infrastructure.Data.Query.Repository.v1;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MetaPoc.Api.Core.IoC
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services
                .AddMvcCore();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddControllers();

            services.AddCors(options => options.AddPolicy("CorsPolicy", policy =>
            {
                policy
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            }));

            return services;
        }

        public static void UseApi(this IApplicationBuilder app, IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            app.ConfigureSwagger(configuration);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public static IServiceCollection AddMediator(this IServiceCollection services, IConfiguration configuration)
        {

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var applicationName = configuration["ApplicationSettings:ApplicationName"];

            var domainAssembly = AppDomain.CurrentDomain.Load($"{applicationName}.Domain");
            var infraQuery = AppDomain.CurrentDomain.Load($"{applicationName}.Infrastructure.Data.Query");

            services.AddMediatR(domainAssembly, infraQuery);

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosQueryRepository, TaxaJurosQueryRepository>();
            return services;
        }
    }
}
