using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Context;
using ApplicationUser.Implementations.Identity;
using ApplicationUser.Implementations.Repository;
using ApplicationUser.Implementations.Service;
using ApplicationUser.Interfaces.Identity;
using ApplicationUser.Interfaces.Repository;
using ApplicationUser.Interfaces.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace ApplicationUser
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services)
        {
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IUserRepository, UserStore>();
            services.AddScoped<IRoleRepository, RoleStore>();
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddControllersWithViews();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAuthentication(
                         CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie
                     (config =>
                     {
                         config.LoginPath = "/auth/login";
                         config.Cookie.Name = "devLightAuth";
                         config.LogoutPath = "/auth/logout";
                         config.ExpireTimeSpan = TimeSpan.FromMinutes(2);
                         config.AccessDeniedPath = "/auth/login";
                     });

            services.AddAuthorization();
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationContext>(options => options.UseMySQL("server=localhost;database=ApplicationUserRole;user=root;password=alfawwazstaa99"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
