namespace BasicApi.ConfigurationExtensions;

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.OpenApi.Models;

[ExcludeFromCodeCoverage]
public static class SwaggerConfigurationExtension
{
    public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Demo API",
                Description = "A basic API to test tools discovered at FOSDEM",
                Version = "v1",
                TermsOfService = null,
                Contact = new OpenApiContact
                {
                    Name = "Jake Foster",
                    Url = new Uri("https://jakefoster954.github.io"),
                    Email = "jake@email.com",
                    Extensions = null
                },
                License = null,
                Extensions = null
            });

            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        return services;
    }
}