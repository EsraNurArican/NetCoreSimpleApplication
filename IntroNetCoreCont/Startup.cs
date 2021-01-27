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
            services.AddControllersWithViews();  // projede aray�z olacak ve mvc kullanacak
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment()) //e�er environment development safhas�ndaysa
            {
                //kullan�c�n�n kar��la�abilece�i hatalar� g�steren sayfay� app'e y�kle
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); // routing kullan

            app.UseEndpoints(endpoints =>
            {
                //ama� sayfay� bir yere y�nlendirmek
                endpoints.MapControllerRoute(name: "default",
                                             pattern: "{controller=Home}/{action=Index}/{id?}"); // ? means nullable
            });
        }
    }
}
