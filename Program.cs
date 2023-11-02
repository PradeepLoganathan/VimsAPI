using Swashbuckle.AspNetCore.SwaggerGen;
using VimsAPI;

var builder = WebApplication.CreateBuilder(args);

// Configure Open API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<SwaggerGeneratorOptions>(o => o.InferSecuritySchemes = true);

// Configure rate limiting
builder.Services.AddRateLimiting();

// Configure OpenTelemetry
builder.AddOpenTelemetry();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRateLimiter();

app.Map("/", () => Results.Redirect("/swagger"));
app.MapGroup("/api/cars").MapCarsEndpoints();
app.MapGroup("/api/Drivers").MapDriversEndpoints();

app.UseHttpsRedirection();
app.Run();