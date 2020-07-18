using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DevIO.UI.Site
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add(item: "/Modulos/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add(item: "/Modulos/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add(item: "/Views/Shared/{0}.cshtml");
            });
            services.AddDbContext<MeuDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MeuDbContext")));
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if ( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("AreaProdutos", "Produtos", "Produtos/{ controller = Cadastro}/{ action = Index}/{ id ?}");
                endpoints.MapAreaControllerRoute("AreaVendas", "Vendas", "Vendas/{ controller = Vendas}/{ action = Index}/{ id ?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
