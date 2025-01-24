using Microsoft.AspNetCore.Mvc.Controllers;
using HomeEnergyApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<IRepository<int, Home>, HomeRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();

//Do NOT remove anything below this comment, this is required to autograde the lesson
public partial class Program { }