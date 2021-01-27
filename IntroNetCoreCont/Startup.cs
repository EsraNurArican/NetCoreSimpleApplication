using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroNetCoreCont
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();  // projede arayüz olacak ve mvc kullanacak
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment()) //eðer environment development safhasýndaysa
            {
                //kullanýcýnýn karþýlaþabileceði hatalarý gösteren sayfayý app'e yükle
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); // routing kullan

            app.UseEndpoints(endpoints =>
            {
                //amaç sayfayý bir yere yönlendirmek
                endpoints.MapControllerRoute(name: "default",
                                             pattern: "{controller=Home}/{action=Index}/{id?}"); // ? means nullable
            });
        }
    }
}
