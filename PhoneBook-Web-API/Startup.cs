using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Phonebook.Models;
using PhoneBook_Web_API.Context;
using PhoneBook_Web_API.Repositories;
using PhoneBook_Web_API.Services;
using PhoneBook_Web_API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook_Web_API
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
            #region [Database Connection]
            string connectionString = Configuration["CONNECTION_STRING"];

            services.AddDbContext<PhoneBookContext>(options =>
                                                    options.UseSqlServer(connectionString));
            #endregion

            #region [Services]
            services.AddScoped<IEntryService, EntryService>();
            services.AddScoped<IPhoneBookService, PhoneBookService>();
            #endregion

            #region [Repositories]
            services.AddScoped<IEntryRepository, EntryRepository>();
            services.AddScoped<IPhoneBookRepository, PhoneBookRepository>();
            #endregion

            services.AddScoped<OrchestrationService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PhoneBookContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
