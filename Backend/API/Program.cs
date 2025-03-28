using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using API.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Linea nueva 1
var dbConfig = new DatabaseConfig();

//Linea nueva 2
builder.Services.AddDbContext<BackendDBContext>(options => options.UseSqlServer(dbConfig.ConnectionString));

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
