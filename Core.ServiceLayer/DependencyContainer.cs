using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Core.DataLayer.Repository;
using Core.DomainLayer.Interfaces;
using Core.ApplicationLayers.Services;
using Core.ApplicationLayers.Interfaces;

namespace Core.ServiceLayer
{
    public class DependencyContainer 
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // application layer
            services.AddScoped<ICourseServices, CourseService>();

            // data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
