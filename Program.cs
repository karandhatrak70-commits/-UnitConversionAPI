using UnitConversionApi.Converters;
using UnitConversionApi.Services;
using UnitConversionApi.Middleware;
var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddScoped<IConversionService, ConversionService>();

builder.Services.AddScoped<IUnitConverter, LengthConverter>();
builder.Services.AddScoped<IUnitConverter, WeightConverter>();
builder.Services.AddScoped<IUnitConverter, TemperatureConverter>();

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
// Swagger Middleware
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.MapControllers();

app.Run();