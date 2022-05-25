using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleAppAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<MiddlewareClass>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("First Writer");
            //});
            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Firstt 1 Writer\n");
            //    await next();
            //    await context.Response.WriteAsync("Firstt 2 Writer\n");
            //});

            //app.UseMiddleware<MiddlewareClass>();

            //app.Map("/code", code);


            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Second Writer\n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapGet("/", async conetext =>
                // {
                //     await conetext.Response.WriteAsync("Hi there");
                // });
            });
        }

        //private void code(IApplicationBuilder app)
        //{
        //    app.Use(async (context, next) =>
        //    {
        //        await context.Response.WriteAsync("Custom 1 Writer\n");
        //        //await next();
        //        //await context.Response.WriteAsync("Custom 2 Writer\n");
        //    });
        //}
    }
}
