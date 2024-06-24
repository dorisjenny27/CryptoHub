using Microsoft.AspNetCore.Authentication.JwtBearer;
using CryptoHub.Services.Interfaces;
using CryptoHub.Services;
using System.ComponentModel.Design;
using System.Net.Http;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace CryptoHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<ICryptoHubService, CryptoHubService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
