using Cantor_Andrei_lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cantor_Andrei_lab5.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Cantor_Andrei_lab5Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cantor_Andrei_lab5Context") ?? throw new InvalidOperationException("Connection string 'Cantor_Andrei_lab5Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ExpenseContext>(opt =>opt.UseInMemoryDatabase("ExpenseList"));

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
