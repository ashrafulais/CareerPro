using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerPro.Model;
using CareerPro.Service.Repository;
using CareerPro.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CareerPro
{
    public class Startup
    {
        public Startup(IConfiguration configuration,
            IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            WebHostEnvironment = webHostEnvironment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment WebHostEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string ConnStr = Configuration.GetConnectionString("LocalConnection");

            services.AddDbContext<CareerDbContext>(options =>
                options.UseSqlServer(ConnStr)
            );

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<CareerDbContext>();

            //services.AddSingleton<UserManager<AppUser>>();
            //services.AddSingleton<SignInManager<AppUser>>();

            services.AddTransient<IAppUserRepo, AppUserRepo>()
                .AddScoped<IAppUserService, AppUserService>();

            services.AddTransient<IPersonRepo, PersonRepo>();

            services.AddTransient<ICompanyRepo, CompanyRepo>();

            services.AddTransient<IJobCategoryRepository, JobCategoryRepository>()
                .AddTransient<IJobCategoryService, JobCategoryService>();

            services.AddTransient<IJobRepository, JobRepository>()
                .AddTransient<IJobService, JobService>();

            //services.AddTransient<ILocationCityRepo, LocationCityRepo>();
            //services.AddTransient<ILocationCountryRepo, LocationCountryRepo>();

            
            
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation() //update cshtml pages peoperly
                //.AddXmlSerializerFormatters()
                .AddJsonOptions(option => option.JsonSerializerOptions
                    .WriteIndented = WebHostEnvironment.IsDevelopment()
                );

            //services.Configure<IdentityOptions>(options =>
            //{
            //    // Password settings.
            //    options.Password.RequireDigit = true;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //    options.Password.RequiredLength = 3;
            //    options.Password.RequiredUniqueChars = 1;

                //    // Lockout settings.
                //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                //    options.Lockout.MaxFailedAccessAttempts = 5;
                //    options.Lockout.AllowedForNewUsers = true;

                //    // User settings.
                //    options.User.AllowedUserNameCharacters =
                //    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //    options.User.RequireUniqueEmail = true;
                //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); //HTTP Strict Transport Security Protocol (HSTS)
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
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
