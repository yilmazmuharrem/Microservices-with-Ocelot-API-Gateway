using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();


builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

//  Health endpoint
app.MapGet("/", () => "Ocelot Gateway is running");

// Ocelot middleware (en sonda gibi dü?ün)
await app.UseOcelot();

app.Run();
