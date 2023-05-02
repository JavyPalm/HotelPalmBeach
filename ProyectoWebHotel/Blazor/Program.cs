using Blazor;
using Blazor.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
<<<<<<< HEAD
Config cadenaConexion = new Config(builder.Configuration.GetConnectionString("MySQL"));
builder.Services.AddSingleton(cadenaConexion);

builder.Services.AddScoped<ILoginServicio, ILoginServicio>();
=======
//builder.Services.AddSingleton<WeatherForecastService>();
>>>>>>> ebc9539c1623b014f4adf07874cc484a1d4939c1

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
