using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSQL.Contexto;
using ApiSQL.Model;
using ApiSQL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ApiSQL
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
            string urlSeguridad = Environment.GetEnvironmentVariable("UrlSeguridad") ?? Configuration.GetValue<string>("UrlSeguridad");
            string apiNameSeguridad = Environment.GetEnvironmentVariable("ApiNameSeguridad") ?? Configuration.GetValue<string>("ApiNameSeguridad");
            string CnnBd = Environment.GetEnvironmentVariable("CnnBd") ?? Configuration.GetValue<string>("CnnBd");

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddOptions();
            services.Configure<ParametroConfig>(Configuration);

            services.AddDbContext<DbVentasContext>(
                    options =>
                    {
                        options.UseSqlServer(CnnBd);
                    }
                );

            services.AddTransient<ICompraService, CompraService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
