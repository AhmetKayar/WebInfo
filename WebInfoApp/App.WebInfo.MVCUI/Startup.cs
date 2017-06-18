using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using App.WebInfo.DataAccess.Concrete.EntityFramework;
using App.WebInfo.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using App.WebInfo.Business.Concrete;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Business.Abstract;

namespace App.WebInfo.MVCUI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.

            services.AddScoped<IMenuService, MenuManager>();
            services.AddScoped<IMenuDal, EfMenuDal>();

            services.AddMvc();
            services.AddDbContext<WebInfoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WebInfoContext")));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();

            services.AddSession();
            services.Configure<IdentityOptions>(options =>
            {
                options.Cookies.ApplicationCookie.LoginPath = "/Login";
                options.Cookies.ApplicationCookie.LogoutPath = "/Login/Logoff";

                options.Cookies.ApplicationCookie.SlidingExpiration = true;
                options.Cookies.ApplicationCookie.ExpireTimeSpan = TimeSpan.FromMinutes(10);

            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
