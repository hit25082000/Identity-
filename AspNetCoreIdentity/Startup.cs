using AspNetCoreIdentity.Config;

namespace AspNetCoreIdentity
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityConfig(Configuration);

            services.AddAuthorizationConfig();

            services.ResolveDependencies();
            
            services.AddControllersWithViews();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.MapRazorPages();

            app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
        }
    }
}