using RealEstateApp.Core.Option;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false)
        .Build();

var connectionStrings = new ConnectionStrings();
builder.Configuration.GetSection(nameof(ConnectionStrings)).Bind(connectionStrings);

builder.Services.AddSingleton<ConnectionStrings>(_ =>connectionStrings);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
