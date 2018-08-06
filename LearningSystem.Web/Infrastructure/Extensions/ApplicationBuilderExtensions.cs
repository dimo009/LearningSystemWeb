using LearningSystem.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Web.Infrastructure.Extensions
{
    //public static class ApplicationBuilderExtensions
    //{
    //    public static IApplicationBuilder UseDataBaseMigration(this IApplicationBuilder app)
    //    {
    //        using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>)
    //        {
    //            serviceScope > ServiceProvider.GetService<LearningSystemDbContext>().Database.Migrate();
    //        }

    //        return app;
    //    }
    //}
}
