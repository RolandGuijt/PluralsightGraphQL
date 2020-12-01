using System.Collections.Generic;
using CarvedRock.Api.Data;
using CarvedRock.Api.GraphQL;
using CarvedRock.Api.Repositories;
using GraphQL.SystemTextJson;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarvedRock.Api
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration config, IWebHostEnvironment env)
        {
            _config = config;
            _env = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CarvedRockDbContext>(options =>
                options.UseSqlServer(_config["ConnectionStrings:CarvedRock"]));

            services.AddScoped<ProductRepository>();
            services.AddScoped<ProductReviewRepository>();

            services.AddScoped<CarvedRockSchema>();
            services.AddSingleton<ReviewMessageService>();

            services.AddGraphQL()
                .AddSystemTextJson(o => o.PropertyNameCaseInsensitive = true)
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddUserContextBuilder(httpContext => new Dictionary<string, object>{ { "User", httpContext.User } })
                .AddDataLoader()
                .AddWebSockets();

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, CarvedRockDbContext dbContext)
        {
            app.UseCors(builder =>
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseWebSockets();
            app.UseGraphQLWebSockets<CarvedRockSchema>("/graphql");
            app.UseGraphQL<CarvedRockSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            dbContext.Seed();
        }
    }
}