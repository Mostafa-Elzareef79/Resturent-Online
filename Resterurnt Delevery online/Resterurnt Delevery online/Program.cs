
using Microsoft.EntityFrameworkCore;
using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;
using Resterurnt_Delevery_online.Repository;

namespace Resterurnt_Delevery_online
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // IoC container Registerations
            builder.Services.AddDbContext<ResteruntDB>(options =>
                options.UseLazyLoadingProxies()
                .UseSqlServer(builder.Configuration.GetConnectionString("cs"))
            );

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<Icity, CityRepo>();
            builder.Services.AddScoped<IRestrunt, RestruntRepo>();
            builder.Services.AddScoped<Iitems, ItemRepo>();
            builder.Services.AddScoped<IItemOrder, ItemOrderRepo>();
            builder.Services.AddScoped<IOrder, OrderRepo>();






            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
