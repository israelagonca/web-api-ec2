using FutShowMe.Application;
using FutShowMe.Application.Interfaces;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using FutShowMe.Domain.Services;
using FutShowMe.Infra.Data.Context;
using FutShowMe.Infra.Data.Interfaces;
using FutShowMe.Infra.Data.Repository;
using FutShowMe.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace FutShowMe.WebAPI
{
    public static class Register
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            //App
            services.AddTransient<IQuadraAppService, QuadraAppService>();
            services.AddTransient<IVideoAppService, VideoAppService>();

            //Domain
            services.AddTransient<IQuadraService, QuadraService>();
            services.AddTransient<IVideoService, VideoService>();

            //Infra dados
            services.AddTransient<IQuadraRepository, QuadraRepository>();
            services.AddTransient<IVideoRepository, VideoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<FutshowmedbContext>();
        }
    }
}
