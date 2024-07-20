using System.Text;
using API.Data;
using API.Errors;
using API.Extensions;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices(builder.Configuration);  
builder.Services.AddIdentityServices(builder.Configuration);  
var app = builder.Build();

// app.UseHttpsRedirection();
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

//Seed Data From Json File
// using var scope = app.Services.CreateScope();
// var services  = scope.ServiceProvider;
// try
// {
//     var context = services.GetRequiredService<DataContext>();
//     await context.Database.MigrateAsync();
//     await Seed.SeedUsers(context);
// }
// catch (Exception ex)
// {
//     var logger = services.GetService<ILogger<Program>>();
//     logger.LogError(ex, "An error occured during migration");
// }

app.Run();
