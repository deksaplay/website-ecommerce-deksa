using website_e_commerce.Data;
using website_e_commerce.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace website_e_commerce
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<InventoryService>();

            services.AddScoped<AuthService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<CartService>();
            services.AddScoped<CheckoutService>();
            services.AddScoped<ProductService>();
            services.AddScoped<PaymentService>();
            services.AddScoped<OrderService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<PromotionService>();
            services.AddScoped<ReportService>();
            services.AddScoped<WishlistService>();
            services.AddScoped<ReviewService>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}