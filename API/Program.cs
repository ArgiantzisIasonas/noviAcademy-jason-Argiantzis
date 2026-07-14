using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;
using System.Text.Json.Serialization;
using WorldRank.Application.Cache;
using WorldRank.Application.Interfaces;
using WorldRank.Application.Service;
using WorldRank.Infrastructure;
using WorldRank.Infrastructure.Caching;
using WorldRank.Infrastructure.Persistencies.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddNLog("nlog.config");

builder.Services.AddDbContext<WorldRankDbContext>(options =>
       options.UseSqlServer(DbConnection.ConnectionString)
    );
builder.Services.AddScoped<IPlayerRepository, EfPlayerRepository>();
builder.Services.AddScoped<IWalletRepository, EfWalletRepository>();


builder.Services.AddMemoryCache();
builder.Services.AddSingleton<ICache, MemoryCacheStore>();


builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IWalletService, WalletService>();

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapGet("/", () => Results.Redirect("/swagger"));
}
app.MapControllers();

app.Run();