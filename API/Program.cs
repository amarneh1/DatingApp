

using API.Errors;
using API.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);    

var app = builder.Build();

// app.UseHttpsRedirection();

// app.UseAuthorization();
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.UseAuthentication();    
app.UseAuthorization(); 
app.MapControllers();

app.Run();
