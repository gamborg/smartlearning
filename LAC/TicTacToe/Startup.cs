using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TicTacToe.Services;
using TicTacToe.Extensions;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Rewrite;

namespace TicTacToe
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IUserService, UserService>();
            services.AddRouting();
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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            var options = new RewriteOptions().AddRewrite("NewUser", "/UserRegistration/Index", false);
            app.UseRewriter(options);

            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapGet("CreateUser", context =>
            {
                var firstName = context.Request.Query["firtsName"];
                var lastName = context.Request.Query["lastName"];
                var email = context.Request.Query["email"];
                var password = context.Request.Query["password"];
                var userservice = context.RequestServices.GetService<IUserService>();
                userservice.RegisterUser(new Models.UserModel { FirstName = firstName, LastName = lastName, Email = email, Password = password });


                return context.Response.WriteAsync($"User {firstName} {lastName} has been sucessfully created.");
            });

            app.UseCommunicationMiddleware();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
