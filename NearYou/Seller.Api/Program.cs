
using Microsoft.EntityFrameworkCore;
using Seller.Api.Data;
using Seller.Api.Repository;

namespace Seller.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<ISellerRepository, SellerRepository>();
            builder.Services.AddTransient<IShopRepository, shopRepository>();

            // Add services to the container.
            builder.Services.AddDbContext<SellerDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SellerDb")));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //builder.Services.AddCors(options =>

            //{

            //    options.AddPolicy("AllowAll", policy =>

            //      policy.AllowAnyOrigin()

            //         .AllowAnyMethod()

            //         .AllowAnyHeader());

            //});
            var app = builder.Build();
            //app.UseCors("AllowAll");
            app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
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
