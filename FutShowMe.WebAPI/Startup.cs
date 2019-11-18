using AutoMapper;
using FutShowMe.Domain;
using FutShowMe.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FutShowMe.WebAPI
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
            Register.RegisterDependencies(services);

            //services.AddAuthentication("Bearer")
            //.AddJwtBearer(options =>
            //{
            //    options.Audience = "3258n8r46oeoscga2jejkbju3g";
            //    options.Authority = "https://cognito-idp.us-west-2.amazonaws.com/us-west-2_8RxRlJIxy";
            //});
            services.Configure<ConfiguracoesGerais>(Configuration.GetSection("ConfiguracoesGerais"));

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<FutshowmedbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddAutoMapper();
            //services.AddCognitoIdentity();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
