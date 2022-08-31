
using Microsoft.EntityFrameworkCore;
using NooriAPI2.Data.Context;
using NooriAPI2.Data.Interfaces;
using NooriAPI2.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer(conn));
builder.Services.AddScoped<IStudentRepo, StudentRepo>();

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
