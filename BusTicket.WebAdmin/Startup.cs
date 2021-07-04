using BusTicket.DataAccess.Concrete.EntityFramework;
using BusTicket.WebAdmin.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Westwind.AspNetCore.LiveReload;

namespace BusTicket.WebAdmin
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
            services.AddDbContext<BusTicketContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });

            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = System.IO.Compression.CompressionLevel.Optimal;
            });

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.Providers.Add<GzipCompressionProvider>();

                options.MimeTypes = new[]
                {
                    "text/css",
                    "application/javascript",
                    "application/json",
                    "text/json",
                    "application/xml",
                    "text/xml",
                    "text/plain",
                    "image/svg+xml",
                    "application/x-font-ttf"
                };
            });

            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddRouting(config =>
            {
                config.LowercaseUrls = true;
            });

            // See https://github.com/RickStrahl/Westwind.AspnetCore.LiveReload
            services.AddLiveReload();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseLiveReload();
                //DataSeeding.Seed(app);
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseResponseCompression();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
        }
    }
}
