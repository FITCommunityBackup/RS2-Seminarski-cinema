using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Utilities.Interfaces;
using Cinema.Web.Api.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Cinema.Services;
using Cinema.Models;
using Cinema.Domain.Entities;
using Cinema.Dal.Repository;
using System.IO.Compression;
using Cinema.Models.Requests;

namespace Cinema.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(x => x.Filters.Add<ErrorFilter>());

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cinema API", Version = "v1" });
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICinemaDbContext, CinemaDbContext>();

            services.AddScoped<IService<MovieDto, object>, BaseService<MovieDto, object, Movie>>();
            services.AddScoped<ICRUDService<MovieDto, object, MovieUpsertRequest, MovieUpsertRequest>,MovieService>();

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<CinemaDbContext>(options => options.UseSqlServer(connection));

            
            //services.AddScoped<IMovieService, MovieService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cinema API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
