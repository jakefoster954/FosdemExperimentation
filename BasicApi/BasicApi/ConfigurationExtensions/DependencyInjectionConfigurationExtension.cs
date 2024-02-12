namespace BasicApi.ConfigurationExtensions;

using Services;

public static class DependencyInjectionConfigurationExtension
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddSingleton<IAgeService, AgeService>();

        return services;
    }
}