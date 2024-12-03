using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

// Add Steeltoe Discovery Client
builder.Services.AddDiscoveryClient();

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

// Use Steeltoe Discovery Client
app.UseDiscoveryClient();

app.MapControllers();

app.Run();
