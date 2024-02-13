using System.Diagnostics.CodeAnalysis;
using BasicApi.ConfigurationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices()
    .AddLogging()
    .AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();

[ExcludeFromCodeCoverage]
public static partial class Program
{
}