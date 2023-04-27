using Serilog;
using StandardizeAddress.BLL.Extensions;
using System.Net.Http.Headers;

namespace StandardizeAddress
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Logger

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            builder.Host.UseSerilog();

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddServices();

            builder.Services.AddSwaggerGen();

            builder.Services.AddHttpClient("Dadata", client =>
            {
                client.BaseAddress = new(builder.Configuration.GetSection("DadataBaseUrlForAddressApi").Value
                             ?? throw new ArgumentNullException("Base address in appsettings file must be defined"));

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string dadataToken = builder.Configuration["DadataToken"] ?? throw new ArgumentNullException("DadataToken is not defined in appsettings file");
                client.DefaultRequestHeaders.Add("Authorization", $"Token {dadataToken}"); // Устанавливаем API-ключ

                string dadataSecret = builder.Configuration["DadataSecret"] ?? throw new ArgumentNullException("DadataSecret is not defined in appsettings file");
                client.DefaultRequestHeaders.Add("X-Secret", dadataSecret); // Устанавливаем секретный ключ
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.Run();
        }
    }
}