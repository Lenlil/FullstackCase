using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackCase.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using FullstackCase.Interfaces;
using FullstackCase.Repositories;
using FullstackCase.Services;

namespace FullstackCase
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<ICountryRepository, CountryDbRepository>();
            services.AddTransient<ICustomerRepository, CustomerDbRepository>();                   
            services.AddTransient<CountryService>();
            services.AddTransient<CustomerService>();

            services.AddMvc();     
            var conn = @"Server=localhost;Database=FullStackCaseDB;Trusted_Connection=True; ConnectRetryCount=0";
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(conn));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
