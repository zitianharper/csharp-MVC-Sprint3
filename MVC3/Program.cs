
using Microsoft.AspNetCore.Mvc;
using MVC3.Models;
using MVC3.Services;
namespace MVC3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

                builder.Services.AddScoped<AuthorsService>();
                builder.Services.AddScoped<AuthorsModel>();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();
            });


            

            app.Run();
        }
    }
}
