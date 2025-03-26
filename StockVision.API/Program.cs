using StockVision.API.DelegatingHandlers;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Options;
using StockVision.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IFinancialRepository, FinancialRepository>();

var financialModelingPrepOptions = builder.Configuration.GetSection(nameof(FinancialModelingPrepOptions))
                                       .Get<FinancialModelingPrepOptions>() ??
                                   throw new NullReferenceException("Options for Financial Modeling Prep are missing");
builder.Services.AddHttpClient("FinancialModelingPrep", options =>
{
    options.BaseAddress = new Uri(financialModelingPrepOptions.ApiUrl);
    options.Timeout = TimeSpan.FromSeconds(10);
}).AddHttpMessageHandler(() => new ApiKeyHandler(financialModelingPrepOptions.ApiKey));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();