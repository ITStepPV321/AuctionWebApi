using AuctionWebApi.Core.Data;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.Helpers;
using AuctionWebApi.Infrastructure.Interfaces;
using AuctionWebApi.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

// FIXED TEAMLEAD'S MISTAKE!!!
namespace AuctionWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string connection = builder.Configuration.GetConnectionString("AuctionDb")!;

            builder.Services.AddDbContext<AuctionDbContext>(options =>
            {
                options.UseSqlServer(connection);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IEntityService<CreateProductDto, ProductDto>, ProductService>();
            builder.Services.AddScoped<IEntityService<CreateAuctionDto, AuctionDto>, AuctionService>();
            builder.Services.AddScoped<IEntityService<CreateInvoiceDto, InvoiceDto>, InvoiceService>();

            builder.Services.AddAutoMapper(typeof(MapperProfile));

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
