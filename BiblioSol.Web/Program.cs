using BiblioSol.Web.Services.insurance;

namespace BiblioSol.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
          
            #region"BiblioSol.Web.Services Configuration"
            builder.Services.AddHttpClient("BiblioSolApi", client =>
            {
                var data = builder.Configuration.GetValue<string>("Apiconfig:BaseUrl");
                client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Apiconfig:BaseUrl") ?? "https://localhost:5001/");
            });
            #endregion

            builder.Services.AddTransient<INetworkTypeHttpService, NetworkTypeHttpService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
