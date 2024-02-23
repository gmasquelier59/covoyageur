using EVS.Api.Datas;
using EVS.Api.Repositories;
using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace EVS.Api.Extensions
{
    public static class WebApplicationBuilderExtension
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepository<User>, UserRepository>();
            builder.Services.AddScoped<IRepository<Feedback>, FeedbackRepository>();
        }

        public static void AddDatabase(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                if (builder.Configuration["Database"] == "mysql")
                {
                    string connectionString = builder.Configuration.GetConnectionString("MysqlConnection")!;
                    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                }
                else
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
                }
            });
        }

        public static void AddControllers(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
        }

        public static void AddSwagger(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API \"En voiture Simone !\"",
                    Description = "Documentation de l'API de l'application \"En voiture Simone !\"",
                    License = new OpenApiLicense
                    {
                        Name = "GNU General Public License v3.0",
                        Url = new Uri("https://www.gnu.org/licenses/gpl-3.0.html")
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }
    }
}
