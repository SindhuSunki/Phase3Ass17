using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment17.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Assignment17DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Assignment17DbContext") ?? throw new InvalidOperationException("Connection string 'Assignment17DbContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
