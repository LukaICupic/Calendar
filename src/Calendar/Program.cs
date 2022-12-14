using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Calendar.Data;

namespace Calendar;

public class Program
{
    public static void Main(string[] args)
    {
        var fileName = Path.Combine("/data", DateTime.UtcNow.Ticks.ToString());
        File.WriteAllText(fileName, "Bok");
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddSingleton<WeatherForecastService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            Console.WriteLine("kk");
        }


        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}