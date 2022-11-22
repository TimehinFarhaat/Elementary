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
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Implementations.Repository;
using MVCE_commerce.Implementations.Service;
using MVCE_commerce.Inetrface.Repository;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce
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
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IChartRepository, ChartRepository>();
            services.AddScoped<IChartService, ChartService>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IStockProductRepository, StockProductRepository>();
            services.AddScoped<IStockProductService, StockProductService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IEWalletRepository, EWalletRepository>();
            services.AddScoped<IEWalletService, EwalletService>();
            services.AddScoped<ICategory, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddControllersWithViews();
            services.AddAuthentication();
            services.AddAuthorization();
            services.AddSession(options =>
            {
                options.Cookie.Name = "CookieName";
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromSeconds(1000);
            });
            services.AddDbContext<ApplicationContext>(options => options.UseMySQL("server=localhost;database=MvcE-Commerce;user=root;password=alfawwazstaa99"));
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
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}