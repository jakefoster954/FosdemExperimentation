using System.Diagnostics.CodeAnalysis;
using BasicApi.ConfigurationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices()
    .AddLogging()
    .ConfigureSwagger()
    .AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();

[ExcludeFromCodeCoverage]
public static partial class Program
{
}