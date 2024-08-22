using Evaluacion2.Builder;
using System;
using Evaluacion2.Conexion;

namespace Evaluacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Configuración del DatabaseConfiguration
            builder.Services.AddSingleton<DatabaseConfiguration>(sp =>
            {
                var dbConfigBuilder = new DatabaseConfigurationBuilder()
                    .SetDatabaseType(DatabaseType.SqlServer) // Cambia esto según sea necesario
                    .SetConnectionString("YourConnectionStringHere");

                return dbConfigBuilder.Build();
            });

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
