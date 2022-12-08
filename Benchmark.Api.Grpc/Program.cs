using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc(options =>
{
    options.MaxReceiveMessageSize = null;
});

builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(IPAddress.Any, 80, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http2;
    });
});

var app = builder.Build();

//app.UseHttpsRedirection();

app.MapGrpcService<Benchmark.Api.Grpc.Services.DataService>();
app.MapGrpcService<Benchmark.Api.Grpc.Services.RepeatedDataService>();

app.MapGet("/", () => "The application is running!");

Benchmark.MockData.Helpers.SeedHelper.SeedData();

app.Run();
