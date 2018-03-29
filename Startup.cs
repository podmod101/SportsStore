using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SpaServices.Webpack;
using TournamentManagement.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TournamentManagement {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(Configuration
                        ["Data:AIMS:ConnectionString"]));

            services.AddMvc().AddJsonOptions(opts =>
                opts.SerializerSettings.ReferenceLoopHandling
                    = ReferenceLoopHandling.Serialize);
        }

        public void Configure(IApplicationBuilder app,
                IHostingEnvironment env, DataContext context) {

            app.UseDeveloperExceptionPage();
            app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions {
                HotModuleReplacement = true
            });

            app.UseStaticFiles();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedData.SeedDatabase(context);
        }
    }
}