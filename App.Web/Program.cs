using Infrastructure;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Service;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using Service.ServiceClasses;
using Service.ServiceInterfaces;
using Infrastructure.RepositoryPattern;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        builder.Services.AddControllers();
        builder.Services.AddRazorPages();

        
        builder.Services.AddIdentity<User,Role>().AddEntityFrameworkStores<OnlineTicketReservationDbContext>().AddDefaultTokenProviders();
        builder.Services.AddDbContext<DbContext, OnlineTicketReservationDbContext>();
        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath="/Identity/Account/Login";
        });
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
         .AddCookie(options =>
{
                 options.LoginPath = "/YourCustomLogin";
                 options.LogoutPath = "/YourCustomLogout";
                 options.AccessDeniedPath = "/YourCustomAccessDenied";
});

        // Add services to the container.
        builder.Services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        builder.Services.AddScoped<IRoleService, RoleService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<ITicketService, TicketService>();
       // builder.Services.AddTransient<IEmailSender, EmailSender>();
      // builder. Services.AddTransient<IEmailSender, SmsSender>();


        builder.Services.AddAuthentication();

        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
        MapsterConfig.RegisterMapping();
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
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoint =>
        {
           app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoint.MapRazorPages();
        });

        //app.MapControllerRoute(
        //    name: "default",
        //    pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
