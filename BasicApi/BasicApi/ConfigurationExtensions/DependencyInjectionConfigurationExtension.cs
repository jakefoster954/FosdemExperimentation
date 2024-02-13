namespace BasicApi.ConfigurationExtensions;

using System.Diagnostics.CodeAnalysis;
using Services;

[ExcludeFromCodeCoverage]
public static class DependencyInjectionConfigurationExtension
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddSingleton<IAgeService, AgeService>();

        return services;
    }
}