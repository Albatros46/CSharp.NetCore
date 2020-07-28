using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ShopApp2.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Controller olusturulmadan once routing olusturmamiz lazim.
            //MVC ve Razor Pages yapısı mevcut(Razor Pages içinde Controller yok)
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

             app.UseRouting();
            //http://localhost:5000/product/details/2 
            //localhost a istek gonderdik product controllerine git details metodunu calistir 2 numarali id li detayi goruntule
            //http://localhost:5000/product/list/3
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default", //localhost veya web adresimizin ana sayfası
                   pattern: "{controller=Home}/{action=Index}/{id?}"//product / list / 3 ->web adresinde gorunecek bolumlerimiz
                                                        //üçüncü bölmenin kullanılmasını istiyorsak  {id}
                                                        //üçüncü bölmenin bazı durumlarda kullanılmasını istiyorsak da {id?}
               );
            });
        }
    }
}
