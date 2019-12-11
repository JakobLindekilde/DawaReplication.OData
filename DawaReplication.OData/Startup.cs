using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace DawaReplication.OData
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ODataDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DawaDatabase")));
            services.AddOData();
            //services.AddMvcCore(action => action.EnableEndpointRouting = false);   // If ASP.NET Core 2.2. (A must)
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(b =>
            {
                b.Select().Expand().Filter().OrderBy().MaxTop(int.MaxValue).Count();
                b.MapODataServiceRoute("odata", "odata", ODataHelper.BuildEdmModel());
            });
        }

    }
}
