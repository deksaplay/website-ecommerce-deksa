using e_commerce.Data;
using e_commerce.Services;
using Microsoft.EntityFrameworkCore;

namespace e_commerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<InventoryService>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<CartService>();
            builder.Services.AddScoped<CheckoutService>();
            builder.Services.AddScoped<ProductService>();
            builder.Services.AddScoped<PaymentService>();
            builder.Services.AddScoped<OrderService>();
            builder.Services.AddScoped<CustomerService>();
            builder.Services.AddScoped<PromotionService>();
            builder.Services.AddScoped<ReportService>();
            builder.Services.AddScoped<WishlistService>();
            builder.Services.AddScoped<ReviewService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddControllers();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
