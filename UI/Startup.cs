using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace UI;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get;}
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        // استفاده از connection string با اولویت متغیر محیطی
        services.AddDbContext<DVdDbContext>(
            options => {
                var connectionString = Configuration.GetConnectionString("postgres");
                options.UseNpgsql(connectionString);
            }
        );
        services.AddSwaggerGen(options =>
       {
           options.SwaggerDoc("v1", new OpenApiInfo
           {
               Version = "v1",
               Title = "My API",
               Description = "API description",
               TermsOfService = new Uri("https://example.com/terms"),
               Contact = new OpenApiContact
               {
                   Name = "Your Name",
                   Email = "your@email.com",
                   Url = new Uri("https://example.com"),
               },
               License = new OpenApiLicense
               {
                   Name = "MIT",
                   Url = new Uri("https://opensource.org/licenses/MIT"),
               }
           });
       });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("v1/swagger.json", "My API V1");
                });
            app.UseDeveloperExceptionPage();
        }
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
