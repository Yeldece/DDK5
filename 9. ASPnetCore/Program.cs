using System;
using Microsoft.AspNetCore.Builder;

namespace webTutorial;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        app.UseRouting();
        app.UseStaticFiles();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );
        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}