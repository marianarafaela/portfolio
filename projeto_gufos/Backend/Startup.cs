using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;

// Entity Framework

// Instalamos o Entity Framework
// dotnet tool install --global dotnet-ef

// Baixamos o pacote SQL Server do Entity Framework
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer

// Baixamos o pacote que escreverá nossos códigos
// dotnet add package Microsoft.EntityFrameworkCore.Design

// Testamos se os pacotes foram instalados
// dotnet restore

// Testamos a instalação do EF ( Entity Framework)
//dotnet ef

// Código que criará o nosso Contexto da Base de Dados e nossos Models
// dotnet ef dbcontext scaffold "Server=DESKTOP-9J1BUVT\SQLEXPRESS; Database=Gufos; User Id=sa; Password=132" Microsoft.EntityFrameworkCore.SqlServer -o Models -d

// SWAGGER - Documentação

// Instalamos o pacote
// dotnet add Backend.csproj package Swashbuckle.AspNetCore -v 5.0.0-rc4

// JWT - JSON WEB Token

// Adicionamos o pacote JWT
// dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.0.0

namespace Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // COnfiguramos como os objetos relacionados aparecerão nos retornos
            services.AddControllersWithViews().AddNewtonsoftJson(
               opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            );

            // Configuramos o Swagger
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{Title = "API", Version = "v1"});

                // Definimos o caminho e arquivo temporário de documentação
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            // Configuramos o JWT

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                c => {
                    c.TokenValidationParameters = new TokenValidationParameters{
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
                }
            );

        }

        // => 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Usamos efetivamente o Swagger
            app.UseSwagger();
            // Especificamos o Endpoint na aplicação
            app.UseSwaggerUI(c =>{
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            // Usamos efetivamente a autenticação
            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
