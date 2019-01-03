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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NJsonSchema;
using NSwag.AspNetCore;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Mvc.Authorization;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Logging;

namespace api
{
    public class Startup
    {

        private readonly IHostingEnvironment _environment;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            _environment = env;

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        { 
            IdentityModelEventSource.ShowPII = true;
            // Register the Swagger services
            if(_environment.IsDevelopment()) services.AddSwaggerDocument();


            var connection = Configuration.GetConnectionString("DefaultConnection");
            var useLocalCertStore = Convert.ToBoolean(Configuration["UseLocalCertStore"]);
            var certificateThumbprint = Configuration["CertificateThumbprint"];

            X509Certificate2 cert;

            if (_environment.IsProduction())
            {
                if (useLocalCertStore)
                {
                    using (X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine))
                    {
                        store.Open(OpenFlags.ReadOnly);
                        var certs = store.Certificates.Find(X509FindType.FindByThumbprint, certificateThumbprint, false);
                        cert = certs[0];
                        store.Close();
                    }
                }
                else
                {
                    //// Azure deployment, will be used if deployed to Azure
                    //var vaultConfigSection = Configuration.GetSection("Vault");
                    //var keyVaultService = new KeyVaultCertificateService(vaultConfigSection["Url"], vaultConfigSection["ClientId"], vaultConfigSection["ClientSecret"]);
                    //cert = keyVaultService.GetCertificateFromKeyVault(vaultConfigSection["CertificateName"]);
                }
            }
            else
            {
                cert = new X509Certificate2(Path.Combine(_environment.ContentRootPath, "devCert.pfx"), "");
            }

            services.AddCors();

            var policy = new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy();

            policy.Headers.Add("*");
            policy.Methods.Add("*");
            policy.Origins.Add("*");
            policy.SupportsCredentials = true;

            services.AddCors(x => x.AddPolicy("corsGlobalPolicy", policy));

            var guestPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireClaim("scope", "dataEventRecords")
                .Build();

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
              .AddIdentityServerAuthentication(options =>
              {
                
                  options.Authority = "https://localhost:5000/";
                  options.ApiName = "dataEventRecords";
                  options.RequireHttpsMetadata = false;


                  options.ApiSecret = Configuration["secret"];
              });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("dataEventRecordsAdmin", policyAdmin =>
                {
                    policyAdmin.RequireClaim("role", "dataEventRecords.admin");
                });
                options.AddPolicy("dataEventRecordsUser", policyUser =>
                {
                    policyUser.RequireClaim("role", "dataEventRecords.user");
                });
                options.AddPolicy("dataEventRecords", policyUser =>
                {
                    policyUser.RequireClaim("scope", "dataEventRecords");
                });
            });

            services.AddMvc(options =>
            {
                //options.Filters.Add(new AuthorizeFilter(guestPolicy));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

            //services.AddScoped<IDataEventRecordRepository, DataEventRecordRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            {
            if (_environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger(); // Serves the registered OpenAPI/Swagger documents by default on `/swagger/{documentName}/swagger.json`
                app.UseSwaggerUi3(); // Serves the Swagger UI 3 web ui to view the OpenAPI/Swagger documents by def ault on `/swagger`
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("corsGlobalPolicy");
            app.UseStaticFiles(); 

            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });



        }
    }
}
