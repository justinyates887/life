using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Life.API.Objects;
using Microsoft.Extensions.Logging;
using Life.API.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Load configuration from environment variables and user secrets
builder.Configuration.AddEnvironmentVariables();
builder.Configuration.AddUserSecrets<Program>();

// Configure MongoDB settings and services
builder.Services.Configure<MongoDBSettings>(options =>
{
    options.ConnectionString = builder.Configuration["MONGODB_CONNECTION_STRING"];
    options.DatabaseName = builder.Configuration["MONGODB_DATABASE_NAME"];
});

builder.Services.AddSingleton(sp =>
    sp.GetRequiredService<IOptions<MongoDBSettings>>().Value);

// Register the repository with the specific collection name for User
builder.Services.AddScoped<IRepository<User>>(sp =>
{
    var settings = sp.GetRequiredService<MongoDBSettings>();
    var logger = sp.GetRequiredService<ILogger<Repository<User>>>();
    return new Repository<User>(settings, logger, "users");
});

// Register logging
builder.Logging.AddConsole();

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
