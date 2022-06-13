using Microsoft.AspNetCore.Builder;
namespace MyWebApp;
class Program
{
    //main method
    static void Main(string[] args)
    {
        //create a new instance of the application builder
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseRouting();
        app.UseStaticFiles();

        app.MapGet("/", () => "Hello World!");
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}