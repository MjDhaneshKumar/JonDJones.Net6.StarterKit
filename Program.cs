var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureAppSettings();
builder.Services.RegisterApplicationServices();

var app = builder.Build();
app.ConfigureMiddleware();

app.Run();