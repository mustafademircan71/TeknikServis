using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TeknikServis.Business.Abstract;
using TeknikServis.Business.Concrete;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.DataAccess.Concrete.EntityFramework.Repositories;
using TeknikServis.MVCUI.Extensions;

namespace TheWayShop.MVCUI
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AdminConfigureService();

            services.RoleConfigureService();

            services.ServiceConfigureService();

            services.FaultConfigureService();

            services.DeviceStatusConfigureService();

            services.CustpmerTypeConfigureService();

            services.MessageConfigureService();

            services.SendMessageConfigureService();
            
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                app.Admin();

                app.Service();

                app.Fault();

                app.Message();
              
             endpoints.MapControllerRoute(
                    name:"serviceQuery",
                    pattern:"query-service",
                    defaults:new { controller="Home",action= "ServiceDetails" });

                endpoints.MapControllerRoute(
                    name:"contactUs",
                    pattern:"contact",
                    defaults:new { controller="Contact",action="Index"});

                endpoints.MapControllerRoute(
                    name: "Message",
                    pattern: "customer-send-message",
                    defaults: new { controller = "Contact", action = "CustomerSendMessage" });

                endpoints.MapControllerRoute(
                   name: "about",
                   pattern: "about",
                   defaults: new { controller = "About", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "ourService",
                   pattern: "our-service",
                   defaults: new { controller = "OurServices", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
